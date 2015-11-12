using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FileRenamer.BusinessLogic
{
    public class RemoveCharacter : IFileRenamer
    {
        public string Rename(string name, string expression)
        {
            return name.Replace(expression, string.Empty);
        }
    }
}
