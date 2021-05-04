using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_VisitorPattern {
    class ResetVisitor : IVisitor {
        public void Visit(Led element) {
            element.Active = 0;
        }

        public void Visit(Ramp element) {
            element.Open = 0;
            element.Count = 0;
        }

        public void Visit(Target element) {
            element.Position = 1;
        }
    }
}
