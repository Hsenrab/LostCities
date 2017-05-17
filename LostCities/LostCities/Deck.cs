using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostCities
{
    class Deck
    {
        private List<Card> cards { set; get; } // initial shuffled list of cardds
        public Stack<Card> cardStack { set; get; } // stack of shuffled cards we will remove.

        // *******************************************************************

        public Deck() //create a deck
        {
            cards = new List<Card>();
            cardStack = new Stack<Card>();
            loaddeck();
        }

        // *******************************************************************
        public void loaddeck()
        {
            cards.Clear();
            int cardnum = 0;
            for (int i = 0; i < 5; i++) // 5 different colours
            {
                for (int j = 2; j < 11; j++) // 9 number cards each colour (total 45 cards)
                {
                    Card currentcard = new Card(); //create a new card

                    //assign colour
                    currentcard.card_number = cardnum;
                    if (i == 0)
                        currentcard.colour = "White";
                    if (i == 1)
                        currentcard.colour = "Green";
                    if (i == 2)
                        currentcard.colour = "Yellow";
                    if (i == 3)
                        currentcard.colour = "Red";
                    if (i == 4)
                        currentcard.colour = "Blue";

                    // assign value
                    currentcard.value = j;

                    // put in deck 
                    cards.Add(currentcard); // adding card to deck
                                            
                    cardnum++; //next card
                }

                for (int j = 0; j < 3; j++) // 3 handshake cards each colour (total 15 cards)
                {
                    Card currentcard = new Card(); //create a new card

                    //assign colour
                    currentcard.card_number = cardnum;
                    if (i == 0)
                        currentcard.colour = "White";
                    if (i == 1)
                        currentcard.colour = "Green";
                    if (i == 2)
                        currentcard.colour = "Yellow";
                    if (i == 3)
                        currentcard.colour = "Red";
                    if (i == 4)
                        currentcard.colour = "Blue";

                    // assign value
                    currentcard.value = 0; // Zero is special value for Handshake card.

                    // put in deck 
                    cards.Add(currentcard); // adding card to deck

                    cardnum++; //next card
                }
            }
        }

        // ********************************************************************
        public void ShuffleStack()
        {
            Random rnd = new Random();

            for (var i = 0; i < cards.Count; i++)
            {
                int swap_index = rnd.Next(i, cards.Count);
                var temp = cards[i];
                cards[i] = cards[swap_index];
                cards[swap_index] = temp;
            }

            cardStack = new Stack<Card>(cards);
        }

        // ********************************************************************
        public Card FindCard(int cardnum)
        {
            foreach (Card a_card in cards)
            {
                if (a_card.card_number == cardnum)
                {
                    return a_card;
                }
            }
            return null;
        }

    }
}
