using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PIHRestApi.Controllers
{
    public class ProgramController : ApiController
    {
        public Response Get([FromUri] Request request)
        {
            return new Response { ProgramId = 1, ProgramName = "program1" };
        }
    }


    public class Request
    {
        public int VersionId { get; set; }
        public int FeatureId { get; set; }
    }

    public class Response
    {
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
    }
}
