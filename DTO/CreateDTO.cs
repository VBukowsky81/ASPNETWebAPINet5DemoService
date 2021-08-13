using System.ComponentModel.DataAnnotations;

namespace WebAPIDemoApp.DTO
{
    public class CreateDTO
    {
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
