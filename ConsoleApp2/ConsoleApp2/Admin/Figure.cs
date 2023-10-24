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

        public Figure(string x, string y)
        {
            this.x = x;
  
            this.y = y;
        }


        public virtual double GetArea()
        {
            return 0;
        }
    }
}
