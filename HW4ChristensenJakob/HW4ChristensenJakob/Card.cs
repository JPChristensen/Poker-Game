using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4ChristensenJakob
{
    class Card
    {
        protected String Face { get; } // Card's face ("Ace", "Two",...)
        protected String Suit { get; } // Card's suit ("Diamonds", "Spades",...)

        // Two-parameter Constructor intiiazes card's Face and Suit
        public Card(String face, String suit)
        {
            Face = face; // Initializes Face of card
            Suit = suit; // Initializes Suit of card
        }

        //gets face
        public String getFace()
        {
            return Face;
        }

        //gets suit
        public String getSuit()
        {
            return Suit;
        }

        public override String ToString() => $"{Face} of {Suit}";
    }
}
