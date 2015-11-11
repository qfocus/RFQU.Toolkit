using FileRenamer.BusinessLogic;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileRenamer
{
    public class ContainerBootstrapper
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IFileReNamer, RemoveCharacter>("remove");

            container.RegisterType<IFileReNamer, ReplaceCharacter>("replace");
        }
    }
}
