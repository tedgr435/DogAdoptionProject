using System.ComponentModel.DataAnnotations;

namespace DogAdoptionProject.Models
{
    public class Dog
    {

        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Name { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Description { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Status { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Type { get; set; }
        public Dog() { }

    }
}
