using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ParallelSearch
{
  public class Program
  {
    static void Main(string[] args)
    {
    }

    public List<T> ParallelSearch<T>(List<T> lista,
                                  Func<T, bool> metodoricerca) 
      where T : class
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

          T item =null;
          do
          {
            lock (codaelementi)
            {
              if (codaelementi.Count > 0)
                item = codaelementi.Dequeue();
              else
                item = null;
            }

            if (item != null)
            {
              if (metodoricerca(item))
                lock (risultati)
                  risultati.Add(item);
            }

            Thread.Sleep(0);
          } while (item != null);
          m.ReleaseMutex();
        });
        workthread.Start(mm);
      }
      foreach (var m in mutexes)
      {
        m.WaitOne(); m.ReleaseMutex();
      }
     //Mutex.WaitAll(mutexes.ToArray());

      return risultati;
    }
    
    public List<T> ParallelSearchSTA<T>(List<T> lista,
                                  Func<T, bool> metodoricerca)
      where T:class
    {
      List<T> result = null;
      Thread tt = new Thread((ThreadStart)delegate
      {
        result = ParallelSearch(lista,metodoricerca);
      });
      tt.SetApartmentState(ApartmentState.MTA);
      tt.Start();

      tt.Join();
      return result;
    }
  }
}
