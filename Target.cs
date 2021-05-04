using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_VisitorPattern {
    class Target : IElement {
        public char Character { get; set; }
        public int Position { get; set; }
        public int Points { get; set; }

        public Target(char character, int position, int points) {
            Character = character;
            Position = position;
            Points = points;
        }

        public void Accept(IVisitor v) {
            v.Visit(this);
        }
    }
}
