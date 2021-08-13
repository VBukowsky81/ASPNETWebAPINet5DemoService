using System.ComponentModel.DataAnnotations;

namespace WebAPIDemoApp.DTO
{
    //Enforcing a bit of formating, for good measure - Max length to 100, NULL objects not allowed
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
