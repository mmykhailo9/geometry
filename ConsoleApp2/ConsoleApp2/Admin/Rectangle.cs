using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Admin
{
    public class Rectangle : Figure
    {
        public int x;
        public int y; 
        public int z;

        public Rectangle(int x, int y, int z)
        {
            this.x = x;

            this.y = y;

            this.z = z;
        }

        public override double GetArea()
        {
            return x * y;
        }
    }
}
