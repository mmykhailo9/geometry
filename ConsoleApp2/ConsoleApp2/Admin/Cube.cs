using ConsoleApp2.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cube
{
    public class Cube
    {
        private double sideLength;

        public Cube(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public double GetVolume()
        {   
            return sideLength * sideLength * sideLength;
        }
    }
    
    
}
            

