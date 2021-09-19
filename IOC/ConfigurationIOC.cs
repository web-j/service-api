using Application.Interface;
using Application.Service;
using Autofac;
using Core.Repository;
using Core.Service;
using Repository;
using Service;

namespace IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC Application
            builder.RegisterType<ApplicationUser>().As<IApplicationUser>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceUser>().As<IServiceUser>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryUser>().As<IRepositoryUser>();
            #endregion            
        }
    }
}
