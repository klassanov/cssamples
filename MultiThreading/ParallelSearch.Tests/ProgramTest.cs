// <copyright file="ProgramTest.cs" company="Microsoft">Copyright © Microsoft 2012</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParallelSearch;
using System.Collections.Generic;

namespace ParallelSearch
{
    [TestClass]
    [PexClass(typeof(Program))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ProgramTest
    {
      [PexGenericArguments(typeof(object))]
      [PexMethod]
      public List<T> ParallelSearch<T>(
          [PexAssumeUnderTest]Program target,
          List<T> lista,
          Func<T, bool> metodoricerca
      )
          where T : class
      {
        List<T> result = target.ParallelSearch<T>(lista, metodoricerca);
        return result;
        // TODO: add assertions to method ProgramTest.ParallelSearch(Program, List`1<!!0>, Func`2<!!0,Boolean>)
      }
    }
}
