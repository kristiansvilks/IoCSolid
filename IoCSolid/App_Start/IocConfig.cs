using IoCSolid.Controllers;
using IoCSolid.Models;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IoCSolid.App_Start
{
    public static class IocConfig
    {
        public static void ConfigureIocUnityContainer()
        {
            IUnityContainer container = new UnityContainer();

            registerServices(container);

            DependencyResolver.SetResolver(new DIResolver(container));
        }

        private static void registerServices(IUnityContainer container)
        {
            container.RegisterType<Repository.IProductRepository, Repository.ProductRepository>();
            container.RegisterType<Interfaces.IServices, Services>();
            container.RegisterType<Interfaces.IDbContext, DbContext>();
        }
    }
}