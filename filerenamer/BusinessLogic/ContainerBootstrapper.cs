
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileRenamer.Business
{
    public class ContainerBootstrapper
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IFileRenamer, RemoveCharacter>("RemoveCharacter");

            container.RegisterType<IFileRenamer, ReplaceCharacter>("ReplaceCharacter");
        }
    }
}
