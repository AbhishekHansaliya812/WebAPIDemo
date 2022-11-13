using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.DBModels;
using Model.RequestModels;
using Model.ResponseModel;
using System.Linq;

namespace WebAPIDemo.Controllers
{
    /// <summary>
    /// Employee Controller
    /// </summary>
    [ApiController]
    [Route("employee")]

    public class EmpoyeeController : ControllerBase
    {
        private readonly WebApidemoContext _context;
        private readonly ILogger<EmpoyeeController> _logger;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public EmpoyeeController(WebApidemoContext context, ILogger<EmpoyeeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Get All Employees
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getallemployees")]
        public async Task<List<Employees>> GetAllEmployees()
        {
            /*Fetching details of all employees*/
            List<Employees> employees = await _context.Employees.Select(s => new Employees()
            {
                EmployeeId = s.EmployeeId,
                EmployeeName = s.EmployeeName,
                MobileNumber = s.MobileNumber,
            }).ToListAsync();

            return employees;
        }

        /// <summary>
        /// Create Employee
        /// </summary>
        /// <param name="employeeCreateRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("createemployee")]
        public async Task<Employees> CreateEmployee(EmployeeCreateRequest employeeCreateRequest)
        {
            /*adding new entry of employee*/
            Employee employee = new Employee()
            {
                EmployeeName = employeeCreateRequest.EmployeeName,
                MobileNumber= employeeCreateRequest.MobileNumber,
            };

            _context.Employees.Add(employee);
            /*Commiting changes into database*/
            await _context.SaveChangesAsync();

            /*Printing details newly added record*/
            Employees employees = new Employees()
            {
                EmployeeId= employee.EmployeeId,
                EmployeeName= employee.EmployeeName,
                MobileNumber=employee.MobileNumber,
            };

            return employees;
        }

        /// <summary>
        /// Updating Employee
        /// </summary>
        /// <param name="employeeUpdateRequest"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("updateemployee")]
        public async Task<Employees> UpdateEmployee(EmployeeUpdateRequest employeeUpdateRequest)
        {
            /*Updating details of existing employee*/
            Employee employee = _context.Employees.Find(employeeUpdateRequest.EmployeeId);

            employee.EmployeeName = employeeUpdateRequest.EmployeeName;
            employee.MobileNumber = employeeUpdateRequest.MobileNumber;

            /*Commiting changes into database*/
            await _context.SaveChangesAsync();

            /*Printing details of updated record*/
            Employees employees = new Employees()
            {
                EmployeeId = employee.EmployeeId,
                EmployeeName = employee.EmployeeName,
                MobileNumber = employee.MobileNumber,
            };
            return employees;
        }

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <param name="employeeDeleteRequest"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("deleteemployee")]
        public async Task<Employees> DeleteEmployee(EmployeeDeleteRequest employeeDeleteRequest)
        {
            /*Deleting record of employee*/
            Employee employee = _context.Employees.Find(employeeDeleteRequest.EmployeeId);

            _context.Employees.Remove(employee);

            /*Commiting changes into database*/
            await _context.SaveChangesAsync();

            /*Printing deatils of removed record*/
            Employees employees = new Employees()
            {
                EmployeeId = employee.EmployeeId,
                EmployeeName = employee.EmployeeName,
                MobileNumber = employee.MobileNumber,
            };
            return employees;
        }
    }
}
