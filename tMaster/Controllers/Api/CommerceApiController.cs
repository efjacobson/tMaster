using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace tMaster.Controllers.Api
{
    public class CommerceApiController : ApiController
    {
        [HttpGet]
        public string GetOffers()
        {
            return "hello";
        }
    }
}
