using System.ComponentModel.DataAnnotations;

namespace EmpApp.Models
{
    public class Employee
    {
        [Key]
        public int Id {get; set; }
        [Required]
        [StringLength(255)]

        public string Name { get; set; }
        public int Age { get; set; }
    }
}