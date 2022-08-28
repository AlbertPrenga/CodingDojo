using System.ComponentModel.DataAnnotations;
using Products_and_Categories.Models;
#pragma warning disable CS8618

public class Category
{
    [Key]
    public int CategoryId {get;set;}
    public string Name {get; set;}
    public List<Association> Associations {get; set;} = new List<Association>();
    public DateTime Created_At {get;set;} = DateTime.Now;
    public DateTime Updated_At {get;set;} = DateTime.Now;

}