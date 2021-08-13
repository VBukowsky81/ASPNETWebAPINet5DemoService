using System.ComponentModel.DataAnnotations;


//Main object class, just an example
namespace WebAPIDemoApp.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string EmployeeName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Position { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}
