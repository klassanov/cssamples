using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading
{
  class Program
  {
    private static object testimone = new object();

    static void Main(string[] args)
    {
      Thread t = Thread.CurrentThread;

      Thread t1 = new Thread(new ThreadStart(Stampa1000));
      Thread t2 = new Thread(new ThreadStart(Stampa1000));

      t1.IsBackground = true;
      t2.IsBackground = true;

      int i = 0;
      //t1.Start();
      //t2.Start();

      ThreadPool.QueueUserWorkItem(new WaitCallback(Stampa1000));

      ThreadPool.QueueUserWorkItem(delegate(object obj)
      {
        i = 8;
        Stampa1000();
      });

      ThreadPool.QueueUserWorkItem(o => { Stampa1000(); });

      //t1.Join();
      //t2.Join();

      Thread.Sleep(10000);
      Console.ReadLine();
    }

    private static void Stampa1000(object obj)
    {
      Stampa1000();
    }

    private static void Stampa1000()
    {
      Random rnd = new Random();

      for (int i = 0; i < 1000; i++)
      {
        lock (testimone)
        {
          Console.WriteLine(string.Format("msg {0}", i));
        }
        Thread.Sleep(rnd.Next(1000));

      }
    }
  }
}
