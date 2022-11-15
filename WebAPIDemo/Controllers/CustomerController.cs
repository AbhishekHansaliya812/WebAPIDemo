using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Validation;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    /* Controller for Customer (Fluent Validation) */
    public class CustomerController : ControllerBase
    {
        #region Checking Fluent Validation
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

        /// <summary>
        /// Update User
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("update")]
        public IActionResult Update(Customer model)
        {
            CustomerValidator customerValidator = new();
            //var validatorResult = customerValidator.Validate(model);

            /*if (!validatorResult.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, validatorResult.Errors);
            }*/

            return StatusCode(StatusCodes.Status200OK, "Model is valid for update!");
        }
        #endregion
    }
}
