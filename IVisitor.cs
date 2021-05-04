using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_VisitorPattern {
    interface IVisitor {
        public void Visit(Led element);
        public void Visit(Ramp element);
        public void Visit(Target element);
    }
}
