using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using Microsoft.Data.Edm;
using sensorlab.api.Models;
using System.Web.Http.OData.Extensions;

namespace sensorlab.api
{
    public static class WebApiConfig
    {
        private static IEdmModel GenerateEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<SensorMeasurement>("SensorMeasurements");
            return builder.GetEdmModel();
        }

        public static void Register(HttpConfiguration config)
        {
            // Web API routes    
            config.MapHttpAttributeRoutes();
            config.Routes.MapODataServiceRoute(routeName: "odata", routePrefix: "odata", model: GenerateEdmModel());
            //config.Routes.MapHttpRoute(
            //    name: "ODataRoute",
            //    routeTemplate: "api/{controller}/{action}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
