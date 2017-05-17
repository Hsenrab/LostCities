using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostCities
{
    class Hand
    {
        public List<Card> cards { set; get; }

        // ******************************************************
        public Hand(Deck currentdeck, int numcards) //constructor creates list and places empty cards in it
        {
            for(int i=0; i<numcards; i++)
            {
                add_card(currentdeck);
            }
        }

        // *******************************************************************************************
        public void add_card(Deck currentdeck) // picks card from top of deck and adds it to end of hand.
        {
            cards.Add(currentdeck.cardStack.Pop());
        }
    }
}
