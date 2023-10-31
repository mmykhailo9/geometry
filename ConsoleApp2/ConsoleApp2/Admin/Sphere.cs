using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Admin
{
    public class Sphere : Figure3D
    {
        public double Radius;
        public int volume;
        
        public Sphere(double r,int x, int y, int z) : base(x, y, z)
        {
            Radius = r;
        }

        public override double GetArea()
        {
            return 4 * Math.PI * Radius * Radius;
        }

        public Sphere(double r, int x, int y, int z) : base(r, x, y, z)
        {
            Radius = r;
            Console.Write("R=");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine(" = {0}", 4.0 / 3 * Math.PI * Radius * Radius * Radius);
        }


    }
}