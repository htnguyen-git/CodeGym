using System;
using System.Collections.Generic;

namespace _bt_InvalidOperationException
{
    class Program
    {
        static void Main(string[] args)
        {
            var personList = new List<Person>();
            personList.Add(new Person() {Name = "Liya", Age = 25 });
            personList.Add(new Person() { Name = "Danya", Age = 15 });

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    personList.Remove(personList[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }
    }
}
