using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileRenamer.BusinessLogic
{
    public class ReplaceCharacter : IFileRenamer
    {
        public string Rename(string name, string oldValue, string newValue)
        {
            return name.Replace(oldValue, newValue);
        }
    }
}
