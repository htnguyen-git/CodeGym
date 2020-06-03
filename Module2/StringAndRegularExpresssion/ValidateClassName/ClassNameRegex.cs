using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidateClassName
{
    class ClassNameRegex
    {
        private string CLASSNAME_REGEX = "^[ACP][0-9]{4}[G-M]$";
        public bool Validate(string regex)
        {
            return Regex.IsMatch(regex, CLASSNAME_REGEX);
        }
    }
}
