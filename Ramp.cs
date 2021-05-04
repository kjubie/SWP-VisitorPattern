using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_VisitorPattern {
    class Ramp : IElement {
        public string Name { get; set; }
        public int Open { get; set; }
        public int Points { get; set; }
        public int Count { get; set; }
        public int Blink { get; set; }

        public Ramp(string name, int open, int points, int count, int blink) {
            Name = name;
            Open = open;
            Points = points;
            Count = count;
            Blink = blink;
        }

        public void Accept(IVisitor v) {
            v.Visit(this);
        }
    }
}
