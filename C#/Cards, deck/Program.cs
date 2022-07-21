class Program
{
    static void Main(string [] args)
    {
        Card card1 = new Card();
        Card card2 = new Card();

        Console.WriteLine("\n ------------printing card--------\n");
        card1.PrintCard();

        Deck deck1 = new Deck();
        Console.WriteLine("\n--------printing Deck ------------\n");
        deck1.printDeck();
        Console.WriteLine("\n-------dealing----------\n");
        deck1.Deal();
        deck1.printDeck();
        Console.WriteLine("\n-------reseting----------\n");
        deck1.reset();
        deck1.printDeck();
        Console.WriteLine("\n-------shufling----------\n");
        deck1.Shufle();
        deck1.printDeck();
        deck1.reset();
        Player player1 = new Player();
        Console.WriteLine("\n-------drawing----------\n");
        card1 = player1.Draw(deck1);
        card2 = player1.Draw(deck1);
        card1.PrintCard();
        card2.PrintCard();
        Console.WriteLine("\n-------printing deck--------\n");
        deck1.printDeck();
        Card card3 ;
        Console.WriteLine("\n-------players hand----------\n");
        for (int i = 0; i < player1.Hand.Count; i++)
        {
        player1.Hand[i].PrintCard();
        }
        player1.Discard(0);
        Console.WriteLine("\n-------players hand----------\n");
        for (int i = 0; i < player1.Hand.Count; i++)
        {
        player1.Hand[i].PrintCard();
        }
     }

 }
