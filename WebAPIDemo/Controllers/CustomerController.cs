using Microsoft.AspNetCore.Mvc;
using Model;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    /* Controller for Customer (Fluent Validation) */
    public class CustomerController : ControllerBase
    {
        /// <summary>
        /// Add customer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public IActionResult Add(Customer model)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            return StatusCode(StatusCodes.Status200OK, "Model is valid!");
        }
    }
}
