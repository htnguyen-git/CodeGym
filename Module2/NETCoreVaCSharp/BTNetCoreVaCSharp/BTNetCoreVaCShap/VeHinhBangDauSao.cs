using System;
using System.Collections.Generic;
using System.Text;

namespace BTVaTHNetCoreVaCShap
{
    class VeHinhBangDauSao
    {
        #region field
        int chieuCao;
        int chieuRong;
        #endregion
        #region public
        public void NhapChieuCao()
        {
            Console.Write("Nhập chiều cao: ");
            chieuCao = int.Parse(Console.ReadLine());
        }
        public void NhapChieuRong()
        {
            Console.Write("Nhập chiều rộng: ");
            chieuRong = int.Parse(Console.ReadLine());
        }
        public void InHinhChuNhat()
        {
            for (int i = 0; i < chieuCao; i++)
            {
                for (int j = 0; j < chieuRong; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Vẽ tam giác vuông
        /// Góc vuông ở đáy
        /// </summary>
        public void InHinhTamGiacVuong1()
        {
            for (int i = 0; i < chieuCao; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Vẽ hình tam giác vuông với góc vuông nằm ở góc trên trái
        /// </summary>
        public void InHinhTamGiacVuong2()
        {

        }
        #endregion
       
    }
}
