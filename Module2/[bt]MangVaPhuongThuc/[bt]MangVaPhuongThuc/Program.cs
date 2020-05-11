using System;
using System.Text;
namespace _bt_MangVaPhuongThuc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ShowMenu();
        }
        static void ShowMenu()
        {
            Console.Clear();
            Menu.Show();
            ChonBaiTap();
        }
        static void ChonBaiTap()
        {
            Console.Write("(0-7) để chọn, (q) để kết thúc chương trình. Option: ");
            string selected = Console.ReadLine();
            switch (selected)
            {
                case "q":
                    Environment.Exit(0);
                    break;
                case "0":
                    var themPhanTuVaoMang = new MyArray();
                    themPhanTuVaoMang.NhapIntArray();
                    themPhanTuVaoMang.ShowIntArray();
                    themPhanTuVaoMang.InsertElementToIntArray();
                    themPhanTuVaoMang.ShowIntArray();
                    break;
                case "1":
                    Console.WriteLine("Xoá phần tử khỏi mảng");
                    var xoaPhanTuKhoiMang = new MyArray();
                    xoaPhanTuKhoiMang.NhapIntArray();
                    xoaPhanTuKhoiMang.ShowIntArray();
                    xoaPhanTuKhoiMang.RemoveElementFromIntArray();
                    xoaPhanTuKhoiMang.ShowIntArray();
                    break;
                case "2":
                    Console.WriteLine("Phần tử lớn nhất trong mảng 2 chiều");
                    var matrix = new MyMatrix();
                    matrix.RandomMatrix(4,6);
                    matrix.ShowMatrix();
                    matrix.maxInMatrix();
                    break;
                case "3":
                    Console.WriteLine("Nhập 2 mảng, rồi gộp thành một mảng thứ 3");
                    Console.WriteLine("Mảng 1");
                    var arr1 = new MyArray();
                    arr1.NhapIntArray();
                    arr1.ShowIntArray();
                    Console.WriteLine("Mảng 2");
                    var arr2 = new MyArray();
                    arr2.NhapIntArray();
                    arr2.ShowIntArray();
                    Console.WriteLine("Sau khi gộp");
                    arr1.GopMang(arr2.GetArray());
                    arr1.ShowIntArray();
                    break;
                case "4":
                    Console.WriteLine("Tìm giá trị nhỏ nhất trong mảng");
                    var timGiaTriNhoNhatTrongMang = new MyArray();
                    timGiaTriNhoNhatTrongMang.NhapIntArray();
                    timGiaTriNhoNhatTrongMang.ShowIntArray();
                    timGiaTriNhoNhatTrongMang.PrintMin();
                    break;
                case "5":
                    Console.WriteLine("Tính tổng các giá trị ở một cột của ma trận ngẫu nhiên 5x5");
                    var matranNgauNhien = new MyMatrix();
                    matranNgauNhien.RandomMatrix(5,5);
                    matranNgauNhien.ShowMatrix();
                    Console.Write("Nhập cột cần tính giá trị");
                    byte col = byte.Parse(Console.ReadLine());
                    matranNgauNhien.InTongMotCot(col);
                    break;
                case "6":
                    Console.WriteLine("Nhập vào một chuỗi, nhập vào một ký tự. Đếm số lần xuất hiện của ký tự trong chuỗi");
                    var demSoLanXuatHien = new MyString();
                    demSoLanXuatHien.NhapChuoi();
                    demSoLanXuatHien.HienChuoi();
                    Console.Write("Nhập ký tự cần đếm số lần xuất hiện");
                    char c = char.Parse(Console.ReadLine());
                    demSoLanXuatHien.InSoLanXuatHien(c);
                    break;
                case "7":
                    Console.WriteLine("Nhập một ma trận 2 chiều hình vuông, in giá trị đường chéo chính");
                    var matranVuong = new MyMatrix();
                    matranVuong.NhapGiaTriChoMang();
                    matranVuong.ShowMatrix();
                    matranVuong.InTongDuongCheoChinh();
                    break;
                default:
                    break;
            }
            Console.Read();
            ShowMenu();
        }
    }
}
