using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_VisitorPattern {
    class Led : IElement {
        public int Number { get; set; }
        public int Active { get; set; }
        public int Colour { get; set; }
        public int Points { get; set; }

        public Led(int number, int active, int colour, int points) {
            Number = number;
            Active = active;
            Colour = colour;
            Points = points;
        }

        public void Accept(IVisitor v) {
            v.Visit(this);
        }
    }
}
