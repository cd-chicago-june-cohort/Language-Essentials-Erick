using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            newDeck.shuffle();
            foreach(Card cardVal in newDeck.cards){
                Console.WriteLine(cardVal.stringVal + " of " + cardVal.Suit);
            }
            foreach(Card cardVal in newDeck.cards){
                Console.WriteLine(cardVal.stringVal + " of " + cardVal.Suit);
            }
            Player erick = new Player("Erick");

            erick.draw(newDeck);
            erick.draw(newDeck);
            erick.draw(newDeck);
            erick.draw(newDeck);
            erick.draw(newDeck);

            foreach(Card uniqueCard in erick.hand){
                Console.WriteLine("MY HAND: " + uniqueCard.stringVal + " of " + uniqueCard.Suit);
            }

            erick.discard(1);
        }
    }
}
