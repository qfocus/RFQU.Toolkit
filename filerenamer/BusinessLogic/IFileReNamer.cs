using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileRenamer.Business
{
    public interface IFileRenamer
    {
        string Rename(string name, string oldValue, string newValue);
    }
}
