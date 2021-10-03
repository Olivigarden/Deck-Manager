using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckManager
{
    // Fine, I'm adding a card class so I can easily store fronts and backs are you happy?  :P
    class Card
    {
        public string Front;
        public string Back;

        public Card()
        {
            // Why would you do this?
        }
        public Card(string front)
        {
            Front = front;
        }
        public Card(string front, string back)
        {
            Front = front;
            Back = back;
        }
    }
}
