using System.ComponentModel.DataAnnotations;

namespace Finaldayexam.Models
{
    public class Employee
    {
        [Key]
       public int EmployeeID { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Adress { get; set; }
        public string Location { get; set; }
    }
}
