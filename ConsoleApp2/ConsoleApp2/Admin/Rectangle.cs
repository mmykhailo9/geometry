using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Admin
{
    public class Rectangle : Figure
    {
        public int height;
        public int width;
        public int length;

        public Rectangle(int height, int width, int length, int x, int y, int z) : base(x, y, z)
        {

            this.height = height;

            this.width = width;

            this.length = length;
        }

        public override double GetArea()
        {
            return height * width * z;
        }
        public double GetPerimetr()
        {
            return height + width + height + width;
        }
    }
}
