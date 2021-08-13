using System.Collections.Generic;
using WebAPIDemoApp.Models;


//Just an interface, to show practical applications, and common usage
namespace WebAPIDemoApp.Data
{
    public interface IEmployeesRepo
    {

        IEnumerable<Employee> GetAll();
        Employee GetEmployeeById(int id);
        void CreateEmployee(Employee empl);
        void UpdateEmployee(Employee empl);
        void DeleteEmployee(Employee empl);

        bool SaveChanges();

    }
}
