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
        public string EmployeeName { get; set; } = null!;

        public string? MobileNumber { get; set; }
    }
}
