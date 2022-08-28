using System.ComponentModel.DataAnnotations;
using Products_and_Categories.Models;
#pragma warning disable CS8618

public class Product 
{
    [Key]
    public int ProductId {get; set;}
    [Required]
    public string Name {get; set;}
    public string Description {get; set;}
    public float Price {get; set;}
    public List<Association> Associations {get; set;} = new List<Association>();
    public DateTime Created_At {get;set;} = DateTime.Now;
    public DateTime Updated_At {get;set;} = DateTime.Now;
}