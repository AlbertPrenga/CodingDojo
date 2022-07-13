class Buffet
{
    public List<Food> Menu;
     
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Cake", 1000, false, true),
            new Food("Sushi", 1000, true, false),
            new Food("Mango", 400, false, true),
            new Food("Cheescake", 1000, false, true),
            new Food("Pepperone", 200, true, false),
            new Food("Beans", 1000, false, false),
            new Food("Chocolate", 1000, false, true),
        };
    }
     
    public Food Serve()
    {
        Random rand = new Random();
        Food Japonese = Menu[rand.Next(Menu.Count)];
        Console.WriteLine(Japonese);
        return Japonese;
    }
}
