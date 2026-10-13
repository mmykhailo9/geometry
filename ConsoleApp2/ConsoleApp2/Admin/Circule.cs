using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Admin
{
    public class Circule : Figure 
    {
        public double Radius;

        public Circule(double r, int x = 0, int y = 0, int z = 0) : base(x, y, z)
        { 
            Radius = r;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
