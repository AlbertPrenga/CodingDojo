#pragma warning disable CS8618
namespace ViewModel_Fun.Models;
public class Human
{
    public string FirstName {get;set;}
                                                    
    public string LastName {get;set;}

    public Human(string first, string last)
    {
        FirstName = first;
        LastName = last;
    }
    public Human()
    {

    }

}
