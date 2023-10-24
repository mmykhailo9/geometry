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

        public Rectangle(int height, int width)
        {
            this.height = height;

            this.width = width;
        }

        public override double GetArea()
        {
            return height * width;
        }
    }
}
