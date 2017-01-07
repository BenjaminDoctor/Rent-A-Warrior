using Heliar.Composition.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Registration;
using System.Linq;
using System.Web;

namespace RAW.ApiHost.App_Start
{
    public class ApiHostDependencyRegistrar : IApplicationDependencyRegistrar
    {
        public void Register(RegistrationBuilder registrations, AggregateCatalog catalog)
        {
        }
    }
}