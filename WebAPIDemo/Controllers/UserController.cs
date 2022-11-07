using Microsoft.AspNetCore.Mvc;
using Model;

namespace WebAPIDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost(Name = "TestPostAPI")]
        public User TestPostAPI(User user)
        {
            user.CompanyName = "Advanced";
            return user;
        }
    }
}
