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
    [Route("employees")]

    /* Controller for CRUD operation on Employee Table in Database */
    public class EmployeeController : ControllerBase
    {
        private readonly WebApidemoContext _context;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(WebApidemoContext context, ILogger<EmployeeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Fetch details of all Employees
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
        /// Fetch detail of employee
        /// </summary>
        /// <param name="EmployeeId">Id of Employee</param>
        /// <returns></returns>
        [HttpGet]
        [Route("getemployee/{EmployeeId}")]
        public async Task<Employees> GetEmployee(int EmployeeId)
        {
            Employee employee = _context.Employees.Find(EmployeeId);
            
            /*Fetching details of employee*/
            Employees employees = new Employees()
            {
                EmployeeId = employee.EmployeeId,
                EmployeeName = employee.EmployeeName,
                MobileNumber = employee.MobileNumber,
            };
            return employees;
        }

        /// <summary>
        /// Create Employee
        /// </summary>
        /// <param name="employeeCreateRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("create")]
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
        [Route("update/{EmployeeId}")]
        public async Task<Employees> UpdateEmployee(int EmployeeId, EmployeeUpdateRequest employeeUpdateRequest)
        {
            /*Updating details of existing employee*/
            Employee employee = _context.Employees.Find(EmployeeId);

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
        [Route("delete/{EmployeeId}")]
        public async Task<Employees> DeleteEmployee(int EmployeeId)
        {
            /*Deleting record of employee*/
            Employee employee = _context.Employees.Find(EmployeeId);

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
