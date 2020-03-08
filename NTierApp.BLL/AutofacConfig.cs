using Autofac;
using NTierApp.BLL.Interfaces;
using NTierApp.BLL.Services;
using NTierApp.DAL;
using NTierApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.BLL
{
    public class AutofacConfig
    {
        public static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<CompanyService>().As<ICompanyService>();
            builder.RegisterType<EmployeeService>().As<IEmployeeService>();
            return builder.Build();
        }
    }
}
