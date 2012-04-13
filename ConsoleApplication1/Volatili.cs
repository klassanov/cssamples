using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pegaso2000
{
  public abstract class Volatili : Animali
  {
    private bool _puòVolare;
    public bool PuòVolare
    {
      get { return _puòVolare; }
      protected set { _puòVolare = value; }
    }

    public abstract void Decolla();
    

  }
}
