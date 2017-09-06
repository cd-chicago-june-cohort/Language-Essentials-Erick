using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();

        public Deck()
        {
            string[] suits = { "spades", "hearts", "clubs", "diamonds" };
            for (var s = 0; s < 4; s += 1)
            {
                for (int v = 1; v <= 13; v += 1)
                {
                    Card newCard = new Card();
                    newCard.Suit = suits[s];
                    newCard.Val = v;
                    if (v > 1 && v < 11)
                    {
                        newCard.stringVal = v.ToString();
                    }
                    else if (v == 1)
                    {
                        newCard.stringVal = "Ace";
                    }
                    else if (v == 11)
                    {
                        newCard.stringVal = "Jack";
                    }
                    else if (v == 12)
                    {
                        newCard.stringVal = "Queen";
                    }
                    else
                    {
                        newCard.stringVal = "King";
                    }
                    cards.Add(newCard);
                }
            }
        }

        public Card deal()
        {       
            Card tempCard = cards[0];
            cards.RemoveAt(0);
            return tempCard;
        }

        public void reset()
        {
            cards.Clear();
            string[] suits = { "spades", "hearts", "clubs", "diamonds" };
            for (var s = 0; s < 4; s += 1)
            {
                for (int v = 1; v <= 13; v += 1)
                {
                    Card newCard = new Card();
                    newCard.Suit = suits[s];
                    newCard.Val = v;
                    if (v > 1 && v < 11)
                    {
                        newCard.stringVal = v.ToString();
                    }
                    else if (v == 1)
                    {
                        newCard.stringVal = "Ace";
                    }
                    else if (v == 11)
                    {
                        newCard.stringVal = "Jack";
                    }
                    else if (v == 12)
                    {
                        newCard.stringVal = "Queen";
                    }
                    else
                    {
                        newCard.stringVal = "King";
                    }
                    cards.Add(newCard);
                }
            }
        }

        public List<Card> shuffle()
        {
            Random rand = new Random();
            for (int i=0; i<cards.Count; i++){
                int j = rand.Next(i, cards.Count);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
            return cards;
        }
    }
}