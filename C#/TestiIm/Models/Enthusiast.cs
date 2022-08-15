using System.ComponentModel.DataAnnotations;
namespace TestiIm.Models;
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations.Schema;

public class Enthusiast
{
    [Key]
    public int EnthusiatId {get; set; }
    public int UserId {get; set;}
    public int HobbieId {get; set;}
    public string Type {get; set;}
    public User? UseriThatLikes {get; set;}
    public Hobbie? HobbieLiked {get; set;}

}