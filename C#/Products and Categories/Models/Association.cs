using System.ComponentModel.DataAnnotations;
using Products_and_Categories.Models;
#pragma warning disable CS8618

public class Association
{   [Key]
    public int AssociationId {get; set;}
    public int ProductId {get; set;}
    public int CategoryId {get; set;}
    public Product? Product {get; set;}
    public Category? Category {get; set;}

}