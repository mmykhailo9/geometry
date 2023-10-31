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

        public Rectangle(int height, int width, int abscissa) :base(height,width,abscissa)
        {

            this.height = height;

            this.width = width;

            this.z = abscissa;
        }

        public override double GetArea()
        {
            return height * width * z;
        }
    }
}
