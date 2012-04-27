using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading2
{
  class Program
  {
    static bool running = true;
    static ManualResetEvent exiting = new ManualResetEvent(false);

    static void Main(string[] args)
    {
      Thread t1 = new Thread(new ThreadStart(Stampa1000));
      t1.Start();

      exiting.Set(); 
    }

    private static void Stampa1000()
    {
      Random rnd = new Random();
      int i = 0;
      while(!exiting.WaitOne(rnd.Next(1000)))
      {
        Console.WriteLine(string.Format("msg {0}", i++));
        //Thread.Sleep(rnd.Next(1000));
      }
    }
  }
}
