using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Template;
using Model;
using System.Security.Cryptography.Xml;

namespace WebAPIDemo.Controllers
{
    [ApiController]
    [Route("users")]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// User information
        /// </summary>
        private List<User> users = new List<User>()
        {
            new User(1,"Abhishek","abhishek@gmail.com",9999999990),
            new User(2,"Meet","meet@gmail.com",9999999991),
            new User(3,"Abhineet","abhineet@gmail.com",9999999992),
            new User(4,"Jyoti","jyoti@gmail.com",9999999993),
        };

        /// <summary>
        /// Get Details of all users
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetUserDetails")]
        public List<User> GetUserDetails()
        { 
            return users;
        }

        /// <summary>
        /// Add user
        /// </summary>
        [HttpPost("PostUserDetails")]
        public List<User> PostUserDetails(User user)
        {
            users.Add(user);
            return users;
        }

        /// <summary>
        /// Update User
        /// </summary>
        [HttpPut("PutUserDetails")]
        public List<User> UpdateUserDetails(User user)
        {
            users[0] = user;
            return users;
        }

        /// <summary>
        /// Delete user
        /// </summary>
        [HttpDelete("DeleteUserDetails")]
        public List<User> DeleteUserDetails(User user)
        {
            users.RemoveAt(0);
            return users;
        }
    }
}
