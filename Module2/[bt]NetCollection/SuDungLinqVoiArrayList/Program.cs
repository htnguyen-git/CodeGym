using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuDungLinqVoiArrayList
{
    class Program
    {
        static readonly string kyTuDanCachCacNhanVien = "\n";
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Staff> arrayList = new List<Staff>();
            arrayList.Add(new Staff() { ID = "1", Age = 24, Name = "Nam" }) ;
            arrayList.Add(new Staff() { ID = "2", Age = 21, Name = "Kiên" });
            arrayList.Add(new Staff() { ID = "3", Age = 24, Name = "Việt" });
            arrayList.Add(new Staff() { ID = "4", Age = 23, Name = "Hằng" });
            arrayList.Add(new Staff() { ID = "5", Age = 24, Name = "Tiến" });

            var result = from staff in arrayList where staff.Age < 24 orderby staff.Name select staff;
            string s = "";
            foreach (Staff staff in result)
            {
                s += staff.ToString() + kyTuDanCachCacNhanVien;
            }
            Console.WriteLine("Nhân viên tuổi nhỏ hơn 24, sắp xếp theo tên");
            Console.WriteLine(s);
        }
    }
}
