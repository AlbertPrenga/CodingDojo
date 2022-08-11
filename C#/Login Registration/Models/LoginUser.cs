#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Login_Registration;
using System.ComponentModel.DataAnnotations.Schema; 
#pragma warning disable CS8618


public class LoginUser
{
    [Required]
    public string Email{get; set;}
    [DataType(DataType.Password)]
    [Required]
    [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
    public string Password { get; set; }
}