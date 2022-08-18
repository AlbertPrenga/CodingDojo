#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Chefs_and_Dishes.Models;
using System.ComponentModel.DataAnnotations.Schema;

public class Dish
{

    [Key]
    public int DishId { get; set; }
    
    [Required]
    [Display(Name ="Name")]
    public string Name { get; set; }
    [Required]
    [Display(Name ="Calories")]
    public string Calories { get; set; }
    [Required]
    [Display(Name ="Tastiness")]
    public int Tastiness{ get; set; } 
    [Required]
    [Display(Name ="Description")]
    public string Description { get; set; }
    [Required]
    public int ChefId {get;set;}
    public Chef? Cook {get;set;}
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}