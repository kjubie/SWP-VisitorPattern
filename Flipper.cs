using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_VisitorPattern {
    class Flipper {
        public int Credits;
        public int Score;

        public IElement[] Elements;

        IVisitor pv;
        IVisitor rv;
        IVisitor resetV;

        public Flipper() {
            Credits = 0;
            Score = 0;
            Elements = new IElement[13];

            pv = new PointsVisitor();
            rv = new ReportVisitor();
            resetV = new ResetVisitor();
        }

        public void Flip() {
            Flipper flipper = new();

            IElement ramp01 = new Ramp("Ramp01", 1, 50, 5, 0);
            IElement ramp02 = new Ramp("Ramp02", 1, 55, 2, 0);
            IElement ramp03 = new Ramp("Ramp03", 0, 65, 3, 0);

            IElement led01 = new Led(0, 1, 1, 30);
            IElement led02 = new Led(1, 1, 2, 25);
            IElement led03 = new Led(2, 0, 3, 45);
            IElement led04 = new Led(3, 0, 2, 55);
            IElement led05 = new Led(4, 1, 1, 20);

            IElement target01 = new Target('a', 1, 65);
            IElement target02 = new Target('b', 0, 55);
            IElement target03 = new Target('c', 1, 45);
            IElement target04 = new Target('d', 1, 35);
            IElement target05 = new Target('e', 0, 50);

            flipper.Elements[0] = ramp01;
            flipper.Elements[1] = ramp02;
            flipper.Elements[2] = ramp03;

            flipper.Elements[3] = led01;
            flipper.Elements[4] = led02;
            flipper.Elements[5] = led03;
            flipper.Elements[6] = led04;
            flipper.Elements[7] = led05;

            flipper.Elements[8] = target01;
            flipper.Elements[9] = target02;
            flipper.Elements[10] = target03;
            flipper.Elements[11] = target04;
            flipper.Elements[12] = target05;

            Console.WriteLine("Flipper!");

            foreach (IElement element in flipper.Elements) {
                element.Accept(pv);
            }

            PointsVisitor pvHelper = (PointsVisitor)pv;
            Console.WriteLine("Points Visitor: " + pvHelper.Points + " Points!\n");

            Console.WriteLine("Report Visitor: \n");

            foreach (IElement element in flipper.Elements) {
                element.Accept(rv);
            }

            Console.WriteLine("\nReset Visitor \n");

            foreach (IElement element in flipper.Elements) {
                element.Accept(resetV);
            }

            Console.WriteLine("Report Visitor: \n");

            foreach (IElement element in flipper.Elements) {
                element.Accept(rv);
            }
        }
    }
}
