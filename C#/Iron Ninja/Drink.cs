
class Drink : IConsumable
{
    public string Name {get;set;}
    public int Calories {get;set;}
    public bool IsSpicy {get;set;}
    public bool IsSweet {get;set;} = true;
    
    // Implement a GetInfo Method
    public string GetInfo()
    {

        return $"{Name} (Food). Calories: {Calories}. Spicy?: {IsSpicy}. sweet?: {IsSweet} ";
    }

    // Add a constructor method

    public Drink( string name, int cal, bool spice, bool sweet)
    {
       Name =  name;
       Calories = cal;
       IsSpicy = spice;
       IsSweet = sweet;

    }
}   

