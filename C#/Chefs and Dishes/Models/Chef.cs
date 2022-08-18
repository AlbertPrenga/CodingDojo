#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Chefs_and_Dishes.Models;
using System.ComponentModel.DataAnnotations.Schema;

public class Chef

{
    [Key]
    public int ChefId { get; set; }
    
    [Required]
    [Display(Name ="First Name")]
    public string FirstName { get; set; }
    [Required]
    [Display(Name ="Last Name")]
    public string LastName { get; set; }
  
    [Required]
    [Display(Name ="DateofBirth")]
    public DateTime DateofBirth { get; set; }
    public List<Dish> CreatedDishes {get;set;} = new List<Dish>();
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}