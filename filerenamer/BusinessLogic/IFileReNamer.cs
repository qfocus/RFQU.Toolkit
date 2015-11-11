using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileRenamer.BusinessLogic
{
    public interface IFileReNamer
    {
        void Rename(string originName);
    }
}
