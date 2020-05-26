using System;
using System.Collections.Generic;
using System.Text;

namespace SuDungLinqVoiArrayList
{
    class Staff
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public override string ToString()
        {
            return $"ID : {ID}, Name : {Name}, Age : {Age}";
        }

    }
}
