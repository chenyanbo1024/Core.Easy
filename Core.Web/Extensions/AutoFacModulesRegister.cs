using Autofac;
using System;
using System.IO;
using System.Reflection;

namespace Core.Web.Extensions
{
    public class AutoFacModulesRegister : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var basePath = AppContext.BaseDirectory;

            var servicesDllFile = Path.Combine(basePath, "Core.Services.dll");
            var repositoryDllFile = Path.Combine(basePath, "Core.Repository.dll");

            if (!(File.Exists(servicesDllFile) && File.Exists(repositoryDllFile)))
            {
                throw new Exception("找不到 Core.Repository.dll 和 Core.Services.dll文件,确认文件位置");
            }

            //builder.RegisterType<LogAOP>();

            // 获取 Services.dll 程序集服务，并注册
            var assemblysServices = Assembly.LoadFrom(servicesDllFile);
            builder.RegisterAssemblyTypes(assemblysServices)
                   .AsImplementedInterfaces()
                   .InstancePerDependency();
            //.EnableInterfaceInterceptors()
            //.InterceptedBy(typeof(LogAOP));

            // 获取 Repository.dll 程序集服务，并注册
            var assemblysRepository = Assembly.LoadFrom(repositoryDllFile);
            builder.RegisterAssemblyTypes(assemblysRepository)
                   .AsImplementedInterfaces()
                   .InstancePerDependency();
        }
    }
}