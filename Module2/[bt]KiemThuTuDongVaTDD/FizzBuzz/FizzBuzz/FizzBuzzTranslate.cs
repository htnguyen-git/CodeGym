using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public static class FizzBuzzTranslate
    {
        public static string ByteToFizzBuzz(byte number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }
        public static string ConvertNumberToFizzBuzz(int number, string ketQua ="")
        {
            if (number == 0)
            {
                return ketQua;
            }
            return ConvertNumberToFizzBuzz(number / 10, ketQua = (ByteToFizzBuzz((byte)(number % 10))).ToString() + ketQua);
        }
        

    }
}
