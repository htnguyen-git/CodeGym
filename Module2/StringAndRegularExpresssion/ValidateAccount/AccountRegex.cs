using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateAccount
{
    class AccountRegex
    {
        private string ACCOUNT_REGEX = "^[_0-9a-z]{6,}$";
        public bool Validate(string regex)
        {
            return Regex.IsMatch(regex, ACCOUNT_REGEX);
        }
    }
}
