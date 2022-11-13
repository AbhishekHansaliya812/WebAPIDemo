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
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; } = null!;

        public string? MobileNumber { get; set; }
    }
}
