using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostCities
{
    class Expedition
    {
        public List<Card> cards;
        public int score;
        public int max_number;
        public string colour;

        public Expedition(string expedition_colour)
        {
            cards = new List<Card>();
            max_number = 0;
            colour = expedition_colour;
            score = 0;
        }

        public int CalculateScore()
        {

            if(cards.Count() == 0) // If no cards in the expedition score is zero.
            {
                return 0;
            }
            else // Otherwise sum up the values of the cards, and count number of multipliers.
            {
                int local_score = 0;
                int multiplier = 1;

                for(int i=0; i<cards.Count(); i++)
                {
                    if (cards[i].card_number == 0)
                    {
                        multiplier++;
                    }
                    else
                    {
                        local_score += cards[i].card_number;
                    }
                }

                // Take the expedition cost of 20 off the score.

                const int EXPEDITION_COST = 20;

                return (local_score - EXPEDITION_COST) * multiplier;
            }
        }

        // *******************************************************************************************
        public void add_card(Card a_card) // Add card to expedition.
        {
            if(a_card.colour != colour)
            {
                throw new ArgumentException("Colour of card doesn't match expedition");
            }
            
            if(a_card.card_number < max_number)
            {
                throw new ArgumentException("Number on the card is lower than the top card");
            }

            max_number = a_card.card_number;
            cards.Add(a_card);
        }


    }
}
