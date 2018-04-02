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
            var A = rs.GenPoint();
            var B = rs.GenPoint();
            var C = rs.GenPoint();
            var D = rs.GenPoint();

            // Centre dans tetrahedre (A, B, C, D) ?
            var AB = B - A;
            var AC = C - A;
            var AD = D - A;

            var AO = O - A;



        }
    }
}
