using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSphere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            var O = new P3D(0, 0, 0);

            var rs = new RandomSphere();
            var p = new P3D[4];

            int N = 100000000;
            int nbIn = 0;
            for (int k = 0; k < N; k++)
            {

                for (int i = 0; i < p.Length; i++)
                {
                    p[i] = rs.GenPoint();
                    //Console.WriteLine($"{p[i]} {p[i].N2()}");
                }

                // Centre dans tetrahedre (A, B, C, D) ?
                var b = RandomSphere.isCenterInTetrahedre(p);
                if (b)
                    nbIn++;
            }
            Console.WriteLine($"{nbIn} {N} {(double)nbIn/N}");
        }
    }
}
