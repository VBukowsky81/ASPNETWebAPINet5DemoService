using System.ComponentModel.DataAnnotations;

namespace WebAPIDemoApp.DTO
{
    public class ReadDTO
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
    }
}
