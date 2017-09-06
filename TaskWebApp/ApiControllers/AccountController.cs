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
    //[RoutePrefix("api/account")]
    public class AccountController : ApiController
    {
        [HttpGet]
        //[Route("sign")]
        public IHttpActionResult SignUpSignIn()
        {
            return Ok();
        }

        [HttpGet]
        [Route("editprofile")]
        public IHttpActionResult EditProfile()
        {
            HttpContext.Current.GetOwinContext().Set("Policy", Startup.EditProfilePolicyId);
            return Ok();
        }
    }
}
