using System;
using System.Collections.Generic;
using System.Linq;
using WebAPIDemoApp.Models;


//SQL database operations setup, all the basic operations are here.
namespace WebAPIDemoApp.Data
{
    public class SqlEmployeesRepo : IEmployeesRepo
    {
        private readonly EmployeesContext _context;

        public SqlEmployeesRepo(EmployeesContext context)
        {
            _context = context;
        }

        public void CreateEmployee(Employee empl)
        {

            if(empl == null)
            {
                throw new ArgumentNullException(nameof(empl));
            }

            _context.Employees.Add(empl);
        }

        public void DeleteEmployee(Employee empl)
        {
            if (empl == null)
            {
                throw new ArgumentNullException(nameof(empl));
            }
            _context.Employees.Remove(empl);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >=0);
        }

        public void UpdateEmployee(Employee empl)
        {
        }
    }
}
