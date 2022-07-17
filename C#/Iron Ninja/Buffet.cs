
class Buffet
{
    public List<IConsumable> Menu;
     
    //constructor
    public Buffet()
    {
        Menu = new List<IConsumable>()
        {
            new Drink("Cola", 1000, false, true),
            new Drink("Wine", 1000, false, true),
            new Drink("Whiskey", 1000, false, true),
            new Drink("Red bull", 1000, false, true),
            new Drink("Orange juice", 1000, false, true),
           
        };
    }

    public IConsumable Serve()
    {
        int randIndex = new Random().Next(0,Menu.Count);
        return Menu[randIndex];
    }

}
