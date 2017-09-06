using System;
using System.Collections.Generic;

namespace DeckOfCards{
    public class Player{
        public string name;
        public List<Card> hand = new List<Card>();

        public Player(string inputName = ""){
            name = inputName;
        }

        public Card draw(Deck takeOne){
            Card cardDealed;
            cardDealed = takeOne.deal();
            hand.Add(cardDealed);
            return cardDealed;
        }

        public Card discard(int index){
            if (hand[index] != null){
                Card temp = new Card();
                temp = hand[index];
                hand.RemoveAt(index);
                return temp;
            } else {
                return null;
            }
        } 
    }
}