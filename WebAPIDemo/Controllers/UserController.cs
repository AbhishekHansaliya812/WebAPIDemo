using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Template;
using Model;

namespace WebAPIDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// THis is just a testing
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost( "TestPostAPI")]
        //[Route("post")]
        public User Post(User user)
        {
            user.CompanyName = "Advanced";
            return user;
        }

        [HttpPut( "TestPutAPI")]
        //[Route("put")]
        public string TestPutAPI(User user)
        {
            return "Welcome to PUT";
        }
    }
}
