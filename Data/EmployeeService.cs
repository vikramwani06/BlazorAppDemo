using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazorApp.Data
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext _context;

        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET 
        public List<EmployeeInfo> GetEmployees()
        {
            var empList = _context.Employees.ToList();
            return empList;
        }

        //INSERT
        public string CreateEmployee(EmployeeInfo employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return "Employee Created Successfully";
        }

        //GET by Id
        public EmployeeInfo GetEmployeeById(int id)
        {
            EmployeeInfo employeeInfo = _context.Employees.FirstOrDefault(x => x.EmployeeId == id);
            return employeeInfo;
        }

        //UPDATE
        public string UpdateEmployee(EmployeeInfo employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
            return "Employee Updated Successfully";
        }

        //DELETE
        public string DeleteEmployee(EmployeeInfo employeeInfo)
        {
            _context.Remove(employeeInfo);
            _context.SaveChanges();
            return "Employee Deleted Successfully";
        }

    }
}
