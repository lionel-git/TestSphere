using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSphere
{
    public class RandomSphere
    {
        private Random _rand = new Random(DateTime.Now.Millisecond);

        public P3D GenPoint()
        {
            double V = 2 * _rand.NextDouble() - 1; // [-1,+1]
            double L = Math.Sqrt(1.0 - V * V);
            double T = 2 * Math.PI * _rand.NextDouble(); // [0,+2.pi]
            return new P3D(Math.Cos(T) * L, Math.Sin(T) * L, V);
        }

       

    }
}
