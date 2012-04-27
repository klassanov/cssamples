using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ParallelSearch
{
  class Program
  {
    static void Main(string[] args)
    {
    }

    public List<T> ParallelSearch<T>(List<T> lista,
                                  Func<T, bool> metodoricerca)
    {
      if (lista == null || metodoricerca == null)
        throw new ArgumentException("lista and metodoricerca cannot be null");


      int tnr = System.Environment.ProcessorCount + 2;
      //int elementi = (int)Math.Floor((double)lista.Count / (double)tnr);

      // trasformo la lista in coda di elementi
      Queue<T> codaelementi = new Queue<T>(lista);

      // creo una lista di mutex e riempio la lista con tanti mutex 
      // quanti sono i threads di cui ho bisogno. 
      List<Mutex> mutexes = new List<Mutex>();
      for (int i = 0; i < tnr; i++)
      {
        mutexes.Add(new Mutex());
      }

      List<T> risultati = new List<T>();

      foreach (var mm in mutexes)
      {
        Thread workthread = new Thread(
          (ParameterizedThreadStart)delegate(object mymutex)
        {
          Mutex m = mymutex as Mutex;
          m.WaitOne();

          T item = default(T);
          do
          {
            lock (codaelementi)
            {
              if (codaelementi.Count > 0)
                item = codaelementi.Dequeue();
              else
                item = default(T);
            }

            if (!item.Equals(default(T)))
            {
              if (metodoricerca(item))
                lock (risultati)
                  risultati.Add(item);
            }

            Thread.Sleep(0);
          } while (!item.Equals(default(T)));
          m.ReleaseMutex();
        });
        workthread.Start(mm);
      }
      Mutex.WaitAll(mutexes.ToArray());

      return risultati;
    }
  }
}
