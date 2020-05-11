using System;
using System.Collections.Generic;
using System.Text;

namespace _bt_MangVaPhuongThuc
{
    class MyMatrix
    {
        private double[,] matrix;

        public MyMatrix() { }

        #region private

        #endregion
        #region public
        public void RandomMatrix(byte row, byte col)
        {
            Console.WriteLine($"Sinh mảng ngẫu nhiên, số hàng : {row} , số cột : {col}");
            matrix = new double[row,col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Random rd = new Random();
                    matrix[i,j] = rd.Next(0,100);
                }
                
            }
        }
        public void ShowMatrix()
        {
            Console.WriteLine("Giá trị của mảng : ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void maxInMatrix()
        {
            double max = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    max = max > matrix[i, j] ? max: matrix[i, j];
                }
            }
            Console.WriteLine($"Phần tử lớn nhất trong mảng là {max}");
        }
        public void InTongMotCot(byte col)
        {
            double tong = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                tong += matrix[i, col];
            }
            Console.WriteLine($"Tổng các giá trị của ma trận ở cột {col} là : {tong}");
        }
        public void InTongDuongCheoChinh()
        {
            if (matrix.GetLength(0) != matrix.GetLength(1))
            {
                Console.WriteLine("Ma trận không phù hợp");
            }
            double tong = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                tong += matrix[i, i];
            }
            Console.WriteLine("Tổng giá trị đường chéo chính là : " + tong);
        }
        public void NhapGiaTriChoMang()
        {
            Console.Write("Số dòng của ma trận ");
            int row = int.Parse(Console.ReadLine());
            
            matrix = new double[row, row];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write($"Phần tử thứ {i}-{j} : ");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }

            }

        }
        #endregion
    }
}
