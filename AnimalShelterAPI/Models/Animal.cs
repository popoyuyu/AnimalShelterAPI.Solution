using System.ComponentModel.DataAnnotations;
namespace AnimalShelterAPI.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    [StringLength(20)]
    public string Name { get; set; }
    [Required]
    public string Species { get; set; }
    [Required]
    [Range(1, 30, ErrorMessage = "Age must be betwen 1 and 30.")]
    public int Age { get; set; }
    [Required]
    public string Gender { get; set; }
    [Required]
    public string Description { get; set; }
  }
}