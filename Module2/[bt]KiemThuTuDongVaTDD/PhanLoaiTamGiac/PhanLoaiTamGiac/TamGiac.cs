using System;
using System.Collections.Generic;
using System.Text;

namespace PhanLoaiTamGiac
{
    public class TamGiac
    {
        
        private readonly double canhA;
        private readonly double canhB;
        private readonly double canhC;

        public TamGiac (double canhA, double canhB, double canhC)
        {
            this.canhA = canhA;
            this.canhB = canhB;
            this.canhC = canhC;
        }
        public static string CheckType(TamGiac tamGiac)
        {
            var a = tamGiac.canhA;
            var b = tamGiac.canhB;
            var c = tamGiac.canhC;
            bool isTriange = false;
            if (a + b > c && a + c > b && b + c > a )
            {
                isTriange = true;
            }
            if (isTriange)
            {
                if (a==b && b==c)
                {
                    return TrangThaiMotTamGiac.isTamGiacDeu;
                }
                if (a == b || b == c || c == a)
                {
                    return TrangThaiMotTamGiac.isTamGiacCan;
                }
                if (a*a + b*b == c*c || a*a + c*c == b*b || b*b + c*c == a*a)
                {
                    return TrangThaiMotTamGiac.isTamGiacVuong;
                }
                return TrangThaiMotTamGiac.isTamGiacThuong;
            }
            return TrangThaiMotTamGiac.notTriangle;
        }
    }
}
