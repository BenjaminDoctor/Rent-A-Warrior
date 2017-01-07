using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

using RAW.Abstractions.Services;
using RAW.Api.Resources.Builders;

namespace RAW.ApiHost.Controllers
{
    [RoutePrefix("warrior")]
    public class WarriorController : ApiController
    {
        private readonly IWarriorService service;
        private readonly WarriorResourceBuilder builder;
        //private readonly ILog logger;

        public WarriorController(IWarriorService service, WarriorResourceBuilder builder)
        {
            if (service == null) throw new ArgumentNullException(nameof(service));
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            this.service = service;
            this.builder = builder;
        }

        [Route("{id?}")]
        public async Task<HttpResponseMessage> Get([FromUri]string id = null)
        {
            if (id == null)
            {
                var results = await service.GetWarrior();
                return await builder.GetResponse(Request, results);
            }
            else
            {
                var results = await service.GetWarrior(id);
                return await builder.GetResponse(Request, results);
            }

            //return warriors().response();
        }

        [Route("salary/{id}")]
        public async Task<HttpResponseMessage> GetNinjaSalary([FromUri]string id)
        {
            if (id != null)
            {
                var results = await service.GetWarriorWithSalary(id);
                return await builder.GetResponse(Request, results);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Missing parameter");
            }
        }
    }
}
