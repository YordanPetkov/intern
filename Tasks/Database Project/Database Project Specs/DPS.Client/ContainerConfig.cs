using Autofac;
using DPS.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DPS.Client
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();

            builder.RegisterType<CreateLogic>().As<ICreateLogic>();
            builder.RegisterType<ReadLogic>().As<IReadLogic>();
            builder.RegisterType<UpdateLogic>().As<IUpdateLogic>();
            builder.RegisterType<DeleteLogic>().As<IDeleteLogic>();

            return builder.Build();
        }
    }
}
