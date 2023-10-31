using ConsoleApp2.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pres figure number and Enter");
            string line = Console.ReadLine();
            int flag = Convert.ToInt32(line);

            Figure block = null;

            if(flag == 1)
            {
                block = new Circule(10, 10 , 10, 10);

            }
            
            if(flag == 2)
            {
                block = new Rectangle(10, 10, 10, 10, 10, 10);
            }

            if(flag == 3)
            {
                block = new Sphere(10, 0, 0, 0);
            }

            if(block != null)
            {
                double result = block.GetArea();
                Console.WriteLine($"Area of figure = {result}");
            }
            else
            {
                Console.WriteLine($"Figure empty");
            }
            
            var key = Console.ReadKey();
        }
    }
}
