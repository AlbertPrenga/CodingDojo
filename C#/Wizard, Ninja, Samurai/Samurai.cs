public class Samurai : Human
{

    
    public Samurai(string name, int str, int intel, int dex) : base(200)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        // Health = hp;
    }
     
    // Build Attack method
    //Provide an override Attack method to Samurai, 
    //which calls the base Attack and reduces the target to 0 if it has less than 50 remaining health points.

    public override int Attack(Human target)
    {   
        base.Attack(target);    // base sulmon fillimisht, pastaj kontrollon nese eshte me e vogel se 50. 
        if ( target.Health < 50)
        {
            target.Health = 0;
        }
        Console.WriteLine("Shendeti i Ninjas tashme eshte " + target.Health);
        return target.Health;
    }

    // Samurai should have a method called Meditate, which when invoked, heals the Samurai back to full health
    public void Meditate()
    {   
        
        Health = 200;
        Console.WriteLine("After meditation health is full " + Health);
        
    }

}
