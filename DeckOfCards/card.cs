using System;

namespace DeckOfCards{
    public class Card{
        public string stringVal;
        public string Suit;
        public int Val;

        public Card(string inputStringVal = "", string inputSuit = "", int inputVal = 0){
            stringVal = inputStringVal;
            Suit = inputSuit;
            Val = inputVal;
        }
    }
}
