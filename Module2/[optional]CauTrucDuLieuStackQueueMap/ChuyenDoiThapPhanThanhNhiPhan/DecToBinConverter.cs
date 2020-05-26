using System;
using System.Collections.Generic;
using System.Text;

namespace ChuyenDoiThapPhanThanhNhiPhan
{
    static class DecToBinConverter
    {
        public static string Convert(int numberDecTobin)
        {
            var DecToBin = new Stack<int>();
            while (numberDecTobin > 0)
            {
                DecToBin.Push(numberDecTobin % 2);
                numberDecTobin /= 2;
            }
            // in kết quả
            string ketQua = "";
            while (DecToBin.Count > 0)
            {
                ketQua += DecToBin.Pop().ToString();
            }
            return ketQua;
        }
    }
}
