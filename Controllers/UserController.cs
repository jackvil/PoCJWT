using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PoCJWT.Controllers
{
    [Authorize]
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        [HttpGet]
       
        public IHttpActionResult GetId(int id)
        {
            var customerFake = "jackvil";
            return Ok(customerFake);
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var users = new string[] { "jackvil", "test1", "test2" };
            return Ok(users);
        }
    }
}