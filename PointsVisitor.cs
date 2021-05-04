using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_VisitorPattern {
    class PointsVisitor : IVisitor {
        public int Points { get; set; }

        public void Visit(Led element) {
            if(element.Colour == 1)
                Points += element.Points;
        }

        public void Visit(Ramp element) {
            Points += element.Points * element.Count;
        }

        public void Visit(Target element) {
            if (element.Position == 0)
                Points += element.Points;
        }
    }
}
