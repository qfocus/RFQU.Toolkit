using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileRenamer.BusinessLogic
{
    public interface IFileRenamer
    {
        string Rename(string name, string oldValue, string newValue);
    }
}
