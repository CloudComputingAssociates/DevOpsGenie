using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DOGService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
                                                        //mtm 11-14-2016; needed to Nuget Microsoft ASP.NET Cors package for .EnableCors() to be available
            var enableCorsAttribute = new EnableCorsAttribute("http://dogservice.azurewebsites.net", "*", "*");

            config.EnableCors(enableCorsAttribute);     //mtm 11-14-2016

                                                        //mtm 11-14-2016; add auto-json formatting to responses
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
