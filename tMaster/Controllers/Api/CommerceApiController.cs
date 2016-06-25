using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace tMaster.Controllers.Api
{
    [RoutePrefix("api/offers")]
    public class CommerceApiController : ApiController
    {
        [HttpGet, Route("{eventID}")]
        public HttpResponseMessage GetOffers(string eventID)
        {
            string json = null;

            try
            {
                using (WebClient wc = new WebClient())
                {
                    json = wc.DownloadString("https://app.ticketmaster.com/commerce/v2/events/" + eventID + "/offers.json?apikey=1NxKoxkq6DbOwXVZeGfwKMnR12D3ebFC");
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(ex.ToString());
            }


            var d = JsonConvert.DeserializeObject(json);
            return Request.CreateResponse(d);

        }
    }
}
