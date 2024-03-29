#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CRUDelicious
{

public class Dish
{   
    [Key]
    public int DishId {get; set;}
    [Required]
    public string Name {get ; set;}
    [Required]
    public string Chef {get; set;}
    [Required]
    [Range(1,5)]
    public int Tastines {get; set;}
    [Required]
    [Range(0, int.MaxValue)]
    public int Calories {get; set;}
    [Required]
    public string Description {get; set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
}