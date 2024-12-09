using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DogAdoptionProject.Models
{
    public class Application
    {
        public int Id { get; set; }
        [ForeignKey("Dog")]
        public int? dogId { get; set; }
        [ForeignKey("User")]
        public int? userId { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Status { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Name { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Description { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? House { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string? Dependents { get; set; }


        public Application() { }
    }
}
