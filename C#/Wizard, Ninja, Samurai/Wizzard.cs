public class Wizzard : Human
{
     public Wizzard(string name, int str, int dex ) : base(25, 50)
    {
        Name = name;
        Strength = str;
        Dexterity = dex;
    }
     
    // Build Attack method
    public override int Attack(Human target)
    {
        int dmg = Intelligence * 5;
        target.Intelligence -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }
    public int Heal(Human target)
    {
        target.Health += Intelligence*10;
        Console.WriteLine("The health after healing is " + target.Health);
        return target.Health;
        
    }
}
