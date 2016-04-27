using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FileRenamer.Business
{
    public class RemoveCharacter : IFileRenamer
    {
        public string Rename(string name, string oldValue, string newValue)
        {
            return name.Replace(oldValue, string.Empty);
        }
    }
}
