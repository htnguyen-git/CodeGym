using System;
using System.Collections.Generic;
using System.Text;

namespace TrienKhaiLopIResizeable.ChucNang
{
    interface IResizeable
    {
        /// <summary>
        /// Resize kích thước hình 
        /// </summary>
        /// <param name="percent"></param>
        void Resize(double percent);
    }
}
