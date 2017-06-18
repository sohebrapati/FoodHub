using FoodHub.API.Services;
using ServiceStack;
using ServiceStack.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodHub
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("MVC 4", typeof(CategoryService).Assembly) { }

        public override void Configure(Funq.Container container)
        {
            SetConfig(new HostConfig
            {
                HandlerFactoryPath = "api"
            });

            ControllerBuilder.Current.SetControllerFactory(
                new FunqControllerFactory(container));

            //Configure Custom User Defined REST Paths for your services
            //ConfigureServiceRoutes();
        }

        //private void ConfigureServiceRoutes()
        //{
        //    Routes
        //        //Hello World RPC example
        //        .Add<Categories>("/Categories");

        //}
    }
}