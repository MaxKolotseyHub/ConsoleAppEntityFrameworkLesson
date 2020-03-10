using Autofac;
using Autofac.Integration.Mvc;
using NTierApp.BLL.Interfaces;
using NTierApp.BLL.Services;
using NTierApp.DAL;
using NTierApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace NTierApp.BLL
{
    public class AutofacConfig
    {
        public static ContainerBuilder GetBuilder(string conntectionString)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().WithParameter("conntectionString", conntectionString);
            builder.RegisterType<CompanyService>().As<ICompanyService>();
            builder.RegisterType<EmployeeService>().As<IEmployeeService>();
            return builder;
        }
    }
}
