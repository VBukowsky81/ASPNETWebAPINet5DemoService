using Microsoft.EntityFrameworkCore;
using WebAPIDemoApp.Models;

//Entity Framework setup, migrations handle all the details automatically, located in Migrations folder
namespace WebAPIDemoApp.Data
{
    public class EmployeesContext : DbContext
    {
        public EmployeesContext(DbContextOptions<EmployeesContext> opt) : base (opt)
        { }
        public DbSet<Employee> Employees { get; set; }
    }
}
