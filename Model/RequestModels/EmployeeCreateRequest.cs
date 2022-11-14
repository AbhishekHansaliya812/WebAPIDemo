using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.RequestModels
{
    /*Request class for adding new entry of employee*/
    public class EmployeeCreateRequest
    {
        /// <summary>
        /// Name of Employee
        /// </summary>
        public string EmployeeName { get; set; } = null!;
        /// <summary>
        /// Mobile number of Employee
        /// </summary>
        public string? MobileNumber { get; set; }
    }
}
