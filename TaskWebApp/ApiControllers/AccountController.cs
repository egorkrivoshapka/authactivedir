using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

using System.Web.Http;

namespace TaskWebApp.ApiControllers
{
    [Authorize]
    public class AccountController : ApiController
    {
        [HttpGet]
        public IHttpActionResult SignUpSignIn()
        {
            //HttpContext.GetOwinContext().Authentication.Challenge();
            return Ok();
        }
    }
}
