#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Dojo_Survey_with_Model.Models;

public class Survey
  {  
    [Required]
    [Display(Name = "Name and Surname")]
    [MinLength(2, ErrorMessage ="Name must be more than two charachtrers")]
    public string Name {get; set;}
    [Required]
    public string Location {get;set;} = null!;
    [Required]
    public string Language {get;set;} = null!;
    [MinLength(20, ErrorMessage ="Comment must be 20 characters")]
    public string Comment {get;set;} = null!;
 
}
