using FileRenamer.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public class RegexCharacter : IFileRenamer
    {


        public string Rename(string name, string oldValue, string newValue)
        {
            Regex regex = new Regex(oldValue);

            Match match = regex.Match(name);

            return regex.Replace(name, newValue);

        }
    }
}
