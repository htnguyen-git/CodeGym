using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace KhoiTaoHamSuDungGeneric
{
    static class MyGeneric<T> 
    {
        static public bool SoSanh(T x, T y)
        {
            return x.Equals(y) ? true : false;
        }
        
    }
}
