using System.ComponentModel.DataAnnotations;
namespace TestiIm.Models;
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
     [Key]
    public int UserId { get; set; }
    [Required]
    [MinLength(2)]
    public string FirstName { get; set; }
    [Required]
    [MinLength(2)]
    public string LastName { get; set; }
    
    [Required]
    [MinLength(3),MaxLength(15)]
    public string UserName { get; set; }
    
    [DataType(DataType.Password)]
    [Required]
    [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
    public string Password { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public List<Hobbie> CreatedHobbies { get; set; } = new List<Hobbie>(); 
    public List<Enthusiast> HobbiesILike { get; set; } = new List<Enthusiast>(); 

    [NotMapped]
    [Compare("Password")]
    [DataType(DataType.Password)]
    public string Confirm { get; set; }
}
public class LoginUser
{
    // No other fields!
    [Required]
    [MinLength(3),MaxLength(15)]
    public string UserName { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
}



