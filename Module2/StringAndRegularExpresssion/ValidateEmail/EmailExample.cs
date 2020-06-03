using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateEmail
{
    class EmailExample
    {
        private string EMAIL_REGEX = "^[A-Za-z0-9]+[A-Za-z0-9]*@[A-Za-z0-9]+(\\.[A-Za-z0-9]+)$";
        public bool Validate(string regex) 
        {
            bool matcher = Regex.IsMatch(regex, EMAIL_REGEX);
            return matcher; 
        }
    }
}
