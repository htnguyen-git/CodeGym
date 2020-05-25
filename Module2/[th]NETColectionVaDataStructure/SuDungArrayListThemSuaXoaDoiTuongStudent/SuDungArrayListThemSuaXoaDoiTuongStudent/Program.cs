using System;
using System.Collections;

namespace SuDungArrayListThemSuaXoaDoiTuongStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentList = new ArrayList();
            studentList.Add(new Student() {Name = "Peter", Age = 20 });
            studentList.Add(new Student() { Name = "John", Age = 21 });
            studentList.Add(new Student() { Name = "Mark", Age = 19 });
            foreach (Student student in studentList)
            {
                Console.WriteLine(student.Name + " " + student.Age);
            }
        }
    }
}
