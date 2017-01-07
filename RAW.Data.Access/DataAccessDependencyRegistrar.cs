using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Registration;
using Heliar.Composition.Core;

namespace RAW.Data.Access
{
    public class DataAccessDependencyRegistrar : ILibraryDependencyRegistrar
    {
        public void Register(RegistrationBuilder registrations, AggregateCatalog catalog)
        {
            registrations.ForType<WarriorRepository>()
                .SetCreationPolicy(CreationPolicy.NonShared)
                .ExportInterfaces()
                .Export();
            registrations.ForType<SalaryRepository>()
                .SetCreationPolicy(CreationPolicy.NonShared)
                .ExportInterfaces()
                .Export();
        }
    }
}
