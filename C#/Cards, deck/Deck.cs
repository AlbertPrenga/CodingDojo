public class Deck
{
    public List<Card> Cards;
    public List<string> Suits = new List<string> {"Clubs", "Diamonds", "Hearts", "Spades"};
    public List<string> Names;
    public List<int> Values = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};

    public Deck()
    {
        Cards = new List<Card>();

        for (int i = 0; i < 4; i++){
            for (int j = 0; i <13 ;i++)
            {
                Cards.Add(new Card(Suits[i], Values[j]));
            }
        }
    }

    public void printDeck()
    {
        for (int i = 0; i < Cards.Count; i++)
        {
            Cards[i].PrintCard();
        }
    }

    public Card Deal()
    {
        Card card1 = Cards[0];
        Cards.RemoveAt(0);
        return card1;
    }
    public void reset()
    {
        Cards = new List<Card>();
        {
            for (int i = 0; i < 4; i ++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Cards.Add(new Card(Suits[i], Values[j]));
                }
            }
        }
    }

    public void Shufle()
    {
        Random rand = new Random();
        for (int i = 0; i < Cards.Count; i++)
        {
            int rast = rand.Next(0,Cards.Count);
            Card temp = Cards[i];
            Cards[i] = Cards[rast];
            Cards[rast] = temp;
        }
    }


}
