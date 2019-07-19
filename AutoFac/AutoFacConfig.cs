using Autofac;
using System.Reflection;

namespace AutoFac_Container
{

    public class AutoFacConfig : Autofac.Module
    {

        public static void RegisterContainer()
        {
            var builder = new ContainerBuilder();


            // NOTE: Register Your AutoMapper Dependency In case you are using it for Object to Object Mapping

            //builder.RegisterModule(new AutoMapperModule());

            // NOTE: Make sure to Register your MVC Controllers as 
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // NOTE: If you are using Repository Pattern, Make sure to register Repository Interface so It can be Inject Interface in controllers via Constructors

            builder.RegisterType(typeof(Repository1)).AsImplementedInterfaces();
            builder.RegisterType(typeof(Repository2)).AsImplementedInterfaces();

            // NOTE: Make sure to also register your AppDbContext so that, AutoFac can create DbContext instance per lifetime scope.ie., Only a single instance when application starts or first invoked.

            builder.Register(c => new AppDbContext()).As(typeof(AppDbContext))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();


            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            //NOTE: Make sure to Register your Web API controllers.

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            // OPTIONAL: Register the Autofac model binder provider.
            builder.RegisterWebApiModelBinderProvider();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);

        }

    }
}
