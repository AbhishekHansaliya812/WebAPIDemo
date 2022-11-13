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
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; } = null!;

        public string? MobileNumber { get; set; }
    }
}
