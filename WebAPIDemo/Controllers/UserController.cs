using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Data;
using System.Security.Claims;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    /* Controller to authenticate Bearer Token and to give access of data to user */
    public class UserController : ControllerBase
    {
        #region Geting data if user is admin
        [HttpGet]
        [Route("Admins")]
        [Authorize]
        public IActionResult AdminEndPoint()
        {
            var currentUser = GetCurrentUser();
            return Ok($"Hi you are an {currentUser.Role}");
        }
        #endregion

        #region Authorization
        private UserModel GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                var userClaims = identity.Claims;
                return new UserModel
                {
                    Username = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value,
                    Role = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value
                };
            }
            return null;
        }
        #endregion
    }
}