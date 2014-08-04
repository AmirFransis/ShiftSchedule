
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using ShiftSchedule.Domain.Interfaces;
using ShiftSchedule.Infrastructure.Data;
using ShiftSchedule.Services;
using ShiftSchedule.Services.Interfaces;

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