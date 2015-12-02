using System.Web.Http;
using SignalRKnockoutDemo.Hubs;
using SignalRKnockoutDemo.Models;

namespace SignalRKnockoutDemo.Controllers
{
    public class WidgetController : SignalRBase<WidgetHub>
    {
        //// POST api/<controller>
        //public HttpResponseMessage Post(Widget item)
        //{
        //    if (item == null)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.BadRequest);
        //    }

        //    // add to database in a real app

        //    // notify all connected clients
        //    Hub.Clients.All.newWidget(item);

        //    // return the item inside of a 201 response
        //    return Request.CreateResponse(HttpStatusCode.Created, item);
        //}


        // POST api/<controller>
        public IHttpActionResult Post(Widget item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            // add to database in a real app

            // notify all connected clients
            Hub.Clients.All.newWidget(item);

            // return the item inside of a 201 response
            return Ok(item);
        }
    }
}