﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TImSoNguyenTo
{
    class OptimizedPrimeFactorization
    {
        public string Name { get; set; }
        public OptimizedPrimeFactorization(string name)
        {
            Name = name;
        }
        public void Run()
        {
            for (int i = 1; i < 500; i++)
            {
                if (CheckPrime(i))
                {
                    Console.WriteLine($"{Name} : {i}");
                    
                }
            }
        }
        private bool CheckPrime(int number)
        {
            for (int i = 2; i <=Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
