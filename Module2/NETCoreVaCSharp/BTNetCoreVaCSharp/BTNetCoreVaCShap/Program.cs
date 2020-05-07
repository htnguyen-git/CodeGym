using System;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace BTVaTHNetCoreVaCShap
{
    class Program
    {
        static void ChonTinhNang()
        {
            Console.Clear();
            Menu.ShowMenuChinh();
            Console.Write("Nhập số từ (0-8) : ");
            string selected = (Console.ReadLine());
            switch (selected)
            {
                case "0":
                    // ĐỌc số thành chữ
                    Console.WriteLine("Nhập số để đọc: (0-999)");
                    int so = int.Parse(Console.ReadLine());
                    SoThanhChu.Doc(so);
                    Console.Read();
                    break;
                case "1":
                    // Hiển thị lời chào
                    Console.WriteLine("Ten ban la gi");
                    string name = Console.ReadLine();
                    HienThiLoiChao.SayHello(name);
                    break;
                case "2":
                    Console.WriteLine("Hiển thị số nguyên tố nhỏ hơn 100 : ");
                    SoNguyenTo.NhoHon(100);
                    Console.Read();
                    break;
                case "3":
                    var menu = new ThietKeMenuChoUngUng();
                    menu.hienThiMenu();
                    break;
                case "4":
                    Console.WriteLine("Tính tiền lãi cho vay");
                    var tienLai = new TinhTienLaiChoVay();
                    tienLai.NhapGiaTri();
                    tienLai.InLaiSuat();
                    break;
                case "5":
                    Console.WriteLine("Tìm ước số chung lớn nhất của 2 số");
                    var uocSo = new TimUocSoChungLonNhat();
                    uocSo.Nhap();
                    uocSo.TinhUocSo();
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "e":
                    Environment.Exit(0);
                    break;
                default:
                    ChonTinhNang();
                    break;
            }
            ChonTinhNang();
        }
        

        static void Main(string[] args)
        {
            //Set up
            Console.OutputEncoding = Encoding.UTF8;
            
            ChonTinhNang();
        }
    }
}
