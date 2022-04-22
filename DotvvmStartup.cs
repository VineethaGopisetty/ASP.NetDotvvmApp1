using System;
using DotVVM.Framework.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotvvmApp1
{
    public class DotvvmStartup : IDotvvmStartup, IDotvvmServiceConfigurator
    {
        public void Configure(DotvvmConfiguration config, string applicationPath)
        {
            ConfigureRoutes(config);
            ConfigureResources(config);
            ConfigureControls(config);
        }

        private void ConfigureControls(DotvvmConfiguration config)
        {
          
        }

        private void ConfigureResources(DotvvmConfiguration config)
        {
        }

        private void ConfigureRoutes(DotvvmConfiguration config)
        {
            config.RouteTable.Add("About","about","Views/About.dothtml");
            config.RouteTable.Add("Students", "students", "Views/Students.dothtml");
        }

        public void ConfigureServices(IDotvvmServiceCollection options)
        {
            
        }
    }
}