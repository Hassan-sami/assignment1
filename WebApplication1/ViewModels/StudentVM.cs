using assignment6.context.entities;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class StudentVM
    {
        [Required]
        public string? Fname { get; set; }
        [Required]
        public string? Lname { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        [Range(20, 25,ErrorMessage = "age between 20 and 25")]
        public int? Age { get; set; }
        public int? DeptId { get; set; }
        

        public IEnumerable<Department>? Departments { get; set;}
    }
}
