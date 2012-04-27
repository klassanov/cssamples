using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParallelSearch;
using System.Threading;

namespace TestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestParallelSearchNull1()
    {
      try
      {
        new Program().ParallelSearch<object>(null, i => i != null);
        Assert.Fail();
      }
      catch (ArgumentException ex)
      { }
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestParallelSerachNull2()
    {
      new Program().ParallelSearch<object>(new List<Object>(), null);
      Assert.Fail();
    }

    [TestMethod]
    public void ListaConPochiValori()
    {
      List<string> valori = new List<string>();
      valori.Add("paolo");
      valori.Add("pippo");
      valori.Add("pluto");
      valori.Add("genoveffa");

      var result =  new Program().ParallelSearch(valori,
                   i => i.StartsWith("g"));
      Assert.AreEqual(1, result.Count);
    }

    [TestMethod]
    public void ListaConPochiValori2()
    {
      List<string> valori = new List<string>();
      valori.Add("genoveffa");

      var result = new Program().ParallelSearch(valori,
                   i => i.StartsWith("g"));
      Assert.AreEqual(1, result.Count);
    }

    [TestMethod]
    public void ListaConPochiValori3()
    {
      List<string> valori = new List<string>();
      valori.Add("pippo");

      var result = new Program().ParallelSearch(valori,
                   i => i.StartsWith("g"));
      Assert.AreEqual(0, result.Count);
    }
  }
}
