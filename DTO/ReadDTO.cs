namespace WebAPIDemoApp.DTO
{

    //Data Transfer Object setups, so as to hide, and not expose original code.
    //Annotations are not needed, since this is GET
    public class ReadDTO
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
    }
}
