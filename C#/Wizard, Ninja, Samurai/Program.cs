
class Program
{

static void Main(string[] args)
{
    Samurai samurai = new Samurai("Jack", 5, 15, 5);
    Human ninja = new Human("jin", 5, 20, 5, 50);
    Wizzard wizzard = new Wizzard("Merlin", 5, 25 );
    Ninja ninja2 = new Ninja("John", 5, 10, 50);
    wizzard.Heal(wizzard);
    Console.WriteLine(wizzard.Health);
    ninja2.Attack(ninja);

    ninja2.Steal(samurai);
    samurai.Attack(ninja2);
    samurai.Meditate();

}
}