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
        private object value;

        public Figure(int x, int y, int z)
        {
            this.x = x;
  
            this.y = y;

            this.z = z;
        }

        public Figure(int x, int y, int z, object value) : this(x, y, z)
        {
            this.value = value;
        }

        public virtual double GetArea()
        {
            return 0;
        }
    }
}
