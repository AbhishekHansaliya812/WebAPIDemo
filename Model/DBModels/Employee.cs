using System;
using System.Collections.Generic;

namespace Model.DBModels;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string? MobileNumber { get; set; }
}
