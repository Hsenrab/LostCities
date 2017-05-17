using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostCities
{
    class Card
    {
        public string colour { set; get; }
        public int value { set; get; }
        public int card_number { set; get; }

        public Card()
        {
            value = -1;
            colour = "";
            card_number = -1;
        }
    }
}
