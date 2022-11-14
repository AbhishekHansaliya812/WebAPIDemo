using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.RequestModels
{
    /*Request class to update record of employee*/
    public class EmployeeUpdateRequest
    {
        /// <summary>
        /// Name of employee
        /// </summary>
        public string EmployeeName { get; set; } = null!;
        /// <summary>
        /// Mobile number of employee
        /// </summary>
        public string? MobileNumber { get; set; }
    }
}
