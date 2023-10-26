using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Admin
{

	public class Figure3D : Figure
	{
		public double Radius;

		public Figure3D(double r, int x, int y, int z) : base(x, y, z)
		{
			Radius = r;
		}
			
    }
	

	}

