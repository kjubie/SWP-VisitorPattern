using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_VisitorPattern {
    class ReportVisitor : IVisitor {
        public void Visit(Led element) {
            Console.WriteLine("LED: Number = " + element.Number + ", Active = " + element.Active + ", Colour = " + element.Colour + ", Points = " + element.Points + ";");
        }

        public void Visit(Ramp element) {
            Console.WriteLine("RAMP: Name = " + element.Name + ", Open = " + element.Open + ", Points = " + element.Points + ", Count = " + element.Count + ", Blink = " + element.Blink + ";");
        }

        public void Visit(Target element) {
            Console.WriteLine("TARGET: Character = " + element.Character + ", Position = " + element.Position +  ", Points = " + element.Points + ";");
        }
    }
}
