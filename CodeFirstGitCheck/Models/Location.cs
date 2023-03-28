using System.ComponentModel.DataAnnotations;

namespace CodeFirstGitCheck.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string LocationName { get; set; }
    }
}
