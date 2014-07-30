
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Domain.Interfaces;
using Infrastructure.Data;
using Services;
using Services.Interfaces;

namespace UI.Installers
{
    public class AppInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(Component.For<IEmployeeService>().ImplementedBy<EmployeeService>().LifestyleTransient());
			container.Register(Component.For<IEmployeeRepository>().ImplementedBy<EmployeeRepository>().LifestyleTransient());

        }
    }
}