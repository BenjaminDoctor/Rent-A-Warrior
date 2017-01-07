using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Registration;
using System.ComponentModel.Composition.Hosting;
using Heliar.Composition.Core;
using RAW.Framework.Services;

namespace RAW.Framework
{
    public class FrameworkDependencyRegistrar : ILibraryDependencyRegistrar
    {
        public void Register(RegistrationBuilder registrations, AggregateCatalog catalog)
        {
            registrations.ForType<WarriorService>()
                .SetCreationPolicy(CreationPolicy.NonShared)
                .ExportInterfaces()
                .Export();
        }
    }
}
