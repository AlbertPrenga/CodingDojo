using System.ComponentModel.DataAnnotations;
namespace TestiIm.Models;
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations.Schema;

public class Hobbie
{
    [Key]
    public int HobbieId { get; set; }
    [Required]
    public string Name {get;set;}
    [Required]
    public string Description { get; set; }
    [Required]
    public int UserId { get; set; }
    // Navigation property for related User object
    public User? Creator { get; set; }
    // public List<Like> Likers { get; set; } = new List<Like>(); 
    public List<Enthusiast> Enthusiasts { get; set; } = new List<Enthusiast>(); 

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}