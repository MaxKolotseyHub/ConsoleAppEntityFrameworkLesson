using Autofac;
using Autofac.Integration.Mvc;
using NTierApp.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTierApp.ASPMVC.App_Start
{
    public class AutofacConfigure
    {
        public static void ConfigureContainer(string conntectionString)
        {
            var builder = AutofacConfig.GetBuilder(conntectionString);
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}