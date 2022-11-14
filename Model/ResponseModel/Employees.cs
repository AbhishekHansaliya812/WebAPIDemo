using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ResponseModel
{
    /*Response class to get details of employees*/
    public class Employees
    {
        /// <summary>
        /// Id of Employee
        /// </summary>
        public int EmployeeId { get; set; }
        /// <summary>
        /// Name of Employee
        /// </summary>
        public string EmployeeName { get; set; } = null!;
        /// <summary>
        /// Mobile number of employee
        /// </summary>
        public string? MobileNumber { get; set; }
    }
}
