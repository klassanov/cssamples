using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Model
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ARGB2Int
  {
    [FieldOffset(0)]
    public int Colore; // Valore ARGB del colore ;#FFCC5578

    [FieldOffset(3)]
    public byte A;
    [FieldOffset(2)]
    public byte R;
    [FieldOffset(1)]
    public byte G;
    [FieldOffset(0)]
    public byte B;
  }
}
