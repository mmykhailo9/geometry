using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Admin
{
    public class Figure
    {
        public int x;
        public int y;
        public int z;
   

        public Figure(int x, int y, int z)
        {
            this.x = x;
  
            this.y = y;

            this.z = z;
        }

        public virtual double GetArea()
        {
            return 0;
        }
    }
}
