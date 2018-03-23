using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using sensorlab.api.Models;
using System.Collections;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Web.Http.OData.Query;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace sensorlab.api.Controllers
{
    

    public class SensorMeasurementsController : ODataController
    {
        


        [EnableQuery]
        [ActionName("GetSensorMeasurements")]
        public IHttpActionResult GetSensorMeasurements(ODataQueryOptions<SensorMeasurement> queryOptions)
        {
            var connectionString = Environment.GetEnvironmentVariable("SQLAZURECONNSTR_sensorlabdb") ?? ConfigurationManager.ConnectionStrings["sensorlabdb"].ConnectionString;
            if (connectionString == null)
                throw new Exception("Cannot find connection string in environment");

            SqlConnection sqlCon = new SqlConnection(connectionString);
            DataContext dataContext = new DataContext(sqlCon);

            Table<SensorMeasurement> sensorMeasurements = dataContext.GetTable<SensorMeasurement>();


            return Ok(sensorMeasurements.AsQueryable());
        }



        // POST api/values
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        [SwaggerOperation("Update")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [SwaggerOperation("Delete")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Delete(int id)
        {
        }
    }
}
