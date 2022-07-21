


public class Player
{
    public string Name;
    public List<Card> Hand = new List<Card>();
    public Player()
    {

    }
    public Card Draw(Deck deck1)
    {
    Random rast = new Random();
    int rand = rast.Next(0,deck1.Cards.Count);
    Card card1 = deck1.Cards[rand];
    deck1.Cards.RemoveAt(rand);
    Hand.Add(card1);
    return card1;

    }

    public Card Discard(int i)
    {
        if (Hand.Count >= i)
        {
            Card car1 = Hand[i];
            return car1;
        }
        else
            return null;
    }
}