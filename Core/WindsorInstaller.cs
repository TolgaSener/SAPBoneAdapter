using System.Data.Entity;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using BaseLibrary.Core;
using BaseLibrary.Core.Contracts;
using BaseLibrary.Data;
using BaseLibrary.Data.Contracts;
using BaseLibrary.Data.Contracts.DataBase;
using BaseLibrary.Data.Contracts.Service.IRepository;
using Castle.DynamicProxy;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace BaseLibrary.Hosting.Api.Core
{

    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            RegisterConfigurationHelpers(container);
            RegisterEngines(container);
            RegisterHttpControllers(container);
            RegisterInterceptors(container);
            RegisterDataRepositories(container);
            RegisterDataRepositories(container);
            RegisterEntityFrameworkContexts(container);
            RegisterUnitOfWork(container);
            RegisterLoggers(container);
            RegisterCheckOutRepositories(container);
            RegisterControllers(container);
        }
        private void RegisterCheckOutRepositories(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                    .BasedOn<ICheckOutRepository>()
                    .WithService
                    .AllInterfaces()
                    .LifestylePerWebRequest());
        }

        private void RegisterLoggers(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                    .BasedOn<ILogger>()
                    .WithServiceBase()
                    .LifestyleSingleton()
            );
        }
        private void RegisterUnitOfWork(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                    .BasedOn<IBaseDbOfWorks>()
                    .WithService
                    .AllInterfaces()
                    .LifestylePerWebRequest());
        }
        private void RegisterDataRepositories(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                    .BasedOn(typeof(IRepository<,>))
                    .WithService
                    .AllInterfaces()
                    .LifestylePerWebRequest()
            );
        }
        private void RegisterEntityFrameworkContexts(IWindsorContainer container)
        {
            container.Register(Component.For<DbContext>()
                .ImplementedBy<CheckOutEntities>()
                .LifestylePerWebRequest()
            );
        }
        private void RegisterEngines(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                    .BasedOn<IBusinessEngine>()
                    .WithService
                    .AllInterfaces()
                    .LifestylePerWebRequest()
            );
        }


        private void RegisterConfigurationHelpers(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                    .BasedOn<IConfigurationHelper>()
                    .WithServiceBase()
                    .LifestyleSingleton()
            );
        }

        private void RegisterHttpControllers(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                    .BasedOn<IHttpController>()
                    .WithService
                    .Self()
                    .LifestylePerWebRequest()
            );
        }
        
        private void RegisterInterceptors(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                    .BasedOn<IInterceptor>()
                    .WithService
                    .Self()
                    .LifestylePerWebRequest()

            );
        }
        private void RegisterControllers(IWindsorContainer container)
        {
            container.Register(
                DependencyContainer.Descriptor
                    .BasedOn<Controller>()
                    .WithService
                    .Self()
                    .LifestylePerWebRequest()
            );
        }
    }
}