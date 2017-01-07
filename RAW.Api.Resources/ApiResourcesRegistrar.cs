using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Registration;
using Heliar.Composition.Core;
using RAW.Api.Resources.Builders;

namespace RAW.Api.Resources
{
    public class ApiResourcesRegistrar : ILibraryDependencyRegistrar
    {
        public void Register(RegistrationBuilder registrations, AggregateCatalog catalog)
        {
            registrations.ForType<WarriorResourceBuilder>()
                .SetCreationPolicy(CreationPolicy.NonShared)
                .ExportInterfaces()
                .Export();
        }
    }
}
