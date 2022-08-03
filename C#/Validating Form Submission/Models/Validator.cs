#pragma warning disable CS8618 
using System.ComponentModel.DataAnnotations;
namespace Validating_Form_Submission.Models;

public class Validator
{   
    [Display(Name ="First Name")]
    [Required]
    [MinLength(4,ErrorMessage = "Name must be four characters or more")]
    public string FirstName {get;set;}
    [Display(Name ="Last Name")]
    [Required]
    [MinLength(4, ErrorMessage ="Last Name must be four characters or more")]
    public string LastName {get;set;}
    [Range(0,Int32.MaxValue,ErrorMessage ="Age must be a positiv number")]
    [Required]
    public int Age {get;set;}
    [Display(Name ="Email Adress")]
    [Required]
    [EmailAddress]
    public string EmailAddress {get;set;}
    [Required]
    [DataType(DataType.Password)]
    [MinLength(8)]
    public string Password {get;set;}
// 
}