using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.SOLID
{
    class ListkovSubsituationPrinciple
    {

        public static void TestLSP()
        {
            Rectangle rec = new Rectangle();
            rec.Width = 5;
            rec.Height = 6;
            var res = CalculateArea(rec);
            Console.WriteLine(res);

            Rectangle sq = new Square();
            sq.Height = 5;
            Console.WriteLine(CalculateArea(sq));
            
        }

        public static int CalculateArea(Rectangle rec) => rec.Height * rec.Width;
    }

    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
    }

    public class Square : Rectangle
    {
        public override int Width
        {
            set
            {
                base.Width = base.Height = value;
            }
        }

        public override int Height
        {
            set
            {
                base.Width = base.Height = value;
            }
        }
    }
}
