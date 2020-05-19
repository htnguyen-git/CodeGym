using _th_KeThua.Modal;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TrienKhaiInterfaceIcompareDeSoSanhCacLopHinhHoc.ChucNang
{
    class CircleCompare : IComparer<Circle>
    {
        public int Compare([AllowNull] Circle x, [AllowNull] Circle y)
        {
            if (x.GetRadius() > y.GetRadius())
            {
                return 1;
            }
            if (x.GetRadius() < y.GetRadius())
            {
                return -1;
            }
            return 0;
        }
    }
}
