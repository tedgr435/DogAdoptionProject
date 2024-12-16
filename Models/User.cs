using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace DogAdoptionProject.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Username { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Password { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Email { get; set; }
        //
        public int? Level { get; set; } = 0;



        public User() { }

    }
}
