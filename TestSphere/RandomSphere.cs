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

        private static P3D O = new P3D(0, 0, 0);

        public P3D GenPoint()
        {
            double V = 2 * _rand.NextDouble() - 1; // [-1,+1]
            double L = Math.Sqrt(1.0 - V * V);
            double T = 2 * Math.PI * _rand.NextDouble(); // [0,+2.pi]
            return new P3D(Math.Cos(T) * L, Math.Sin(T) * L, V);
        }

        private static bool IsGoodSide(P3D A, P3D B, P3D C, P3D D, P3D M)
        {
            var n = P3D.CrossProduct(B - A, C - A); // n = AB x AC, normale au plan (A,B,C)
            var d = P3D.ScalarProduct(n, D - A); // n.AD
            var m = P3D.ScalarProduct(n, M - A); // n.AM
            return d * m > 0; // si d et m sont de meme signes M et D sont du meme coté
        }

        public static bool isCenterInTetrahedre(P3D[] p)
        {
            bool isGoodSide = true;
            for (int i = 0; i < 4; i++)
                isGoodSide = isGoodSide && IsGoodSide(p[i], p[(i + 1) % 4], p[(i + 2) % 4], p[(i + 3) % 4], O);
            return isGoodSide;
        }
    }
}
