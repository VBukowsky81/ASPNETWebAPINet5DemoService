using Microsoft.EntityFrameworkCore;
using WebAPIDemoApp.Models;

namespace WebAPIDemoApp.Data
{
    public class EmployeesContext : DbContext
    {
        public EmployeesContext(DbContextOptions<EmployeesContext> opt) : base (opt)
        { }
        public DbSet<Employee> Employees { get; set; }
    }
}
