using RAW.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RAW.Api.Resources.Builders
{
    public class WarriorResourceBuilder
    {
        public async Task<HttpResponseMessage> GetResponse(HttpRequestMessage request, IWarrior ninja)
        {
            HttpResponseMessage response;

            if (ninja != null)
            {
                response = request.CreateResponse(HttpStatusCode.OK, ninja);
            }
            else
            {
                response = request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }

            return response;
        }

        public async Task<HttpResponseMessage> GetResponse(HttpRequestMessage request, IEnumerable<IWarrior> ninjas)
        {
            HttpResponseMessage response;

            if (ninjas.Count() > 0)
            {
                response = request.CreateResponse(HttpStatusCode.OK, ninjas);
            }
            else
            {
                response = request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }

            return response;
        }

        public async Task<HttpResponseMessage> GetResponse(HttpRequestMessage request, IWarriorSalary warriorSalary)
        {
            HttpResponseMessage response;

            if (warriorSalary != null)
            {
                response = request.CreateResponse(HttpStatusCode.OK, warriorSalary);
            }
            else
            {
                response = request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }

            return response;
        }

        public async Task<HttpResponseMessage> GetResponse(HttpRequestMessage request, IEnumerable<IWarriorSalary> ninjasSalaries)
        {
            HttpResponseMessage response;

            if (ninjasSalaries.Count() > 0)
            {
                response = request.CreateResponse(HttpStatusCode.OK, ninjasSalaries);
            }
            else
            {
                response = request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }

            return response;
        }
    }
}
