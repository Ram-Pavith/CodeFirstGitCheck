using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace CodeFirstGitCheck.Models
{
    public class Employee
    {
        [Key]
        public int Eid { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name ="Employee Name")]
        public string Ename { get; set; }

        [Required(ErrorMessage ="Enter Email ID")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Enter valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="*")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        

        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords doesnot match")]
        [NotMapped]
        public string CPassword { get; set;}

        [Required]
        [Range(0,100,ErrorMessage ="Age should be from 0 - 100")]
        public int age { get; set; }

        [Display(Name ="Date of Birth")]
        public DateTime dob { get; set; }

        [StringLength(10,MinimumLength =10,ErrorMessage ="Phone number should be 10 digits")]
        [Display(Name ="Phone Number")]
        public string pnumber { get; set; }
    }
}
