using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidatePhoneNumber
{
    
    class PhoneNumberRegex
    {
        private string PHONENUMBER_REGEX = "^[(][0-9]{2}[)][-][(][0][0-9]{9}[)]";
        public bool Validate(string regex)
        {
            return Regex.IsMatch(regex, PHONENUMBER_REGEX);
        }

    }
}
