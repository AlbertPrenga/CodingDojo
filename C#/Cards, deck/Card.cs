public class Card
{
    public Card()
    {

    }
    public string Suit = "Hearts";
    public int Val = 1;
    public string Name = "Ace";
    public void PrintCard()
    {
        Console.WriteLine(Val + ""+ Name + "of" + Suit);
    }

    public Card(string suit, int val)
    {
        Suit = suit;
        Val= val;
        // Name = name
    }
}
