public class Ninja : Human
{

    public Ninja(string name, int str, int intel, int hp) : base(175)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Health = hp;
    }

     
    // Build Attack method

    public override int Attack(Human target)
    {   
        Random rand = new Random();
        int rnd = rand.Next(1,6);
        if (rnd == 1){
            target.Health -= 10;
        }
        target.Health -= Dexterity*5;
        Console.WriteLine(target.Health);
        return (target.Health);
    }
    //Ninja should have a method called Steal, reduces a target Human's health by 5 and adds this amount to its own health.

    public int Steal(Human target)
    {   
        target.Health -= 5;
        Health += 5;
        Console.WriteLine("Ninja stole from samurai 5 poins and now its new health is " + Health + " points.");
        return target.Health;
    }
}
