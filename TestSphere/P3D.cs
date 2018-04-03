using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSphere
{
    public class P3D
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public P3D(double x ,double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static P3D operator-(P3D A, P3D B)
        {
            return new P3D(A.x - B.x, A.y - B.y, A.z - B.z);
        }

        public static P3D CrossProduct(P3D A, P3D B)
        {
            return new P3D(+A.y * B.z - A.z * B.y, -A.x * B.z + A.z * B.x, +A.x * B.y - A.y * B.x);
        }

        public static double ScalarProduct(P3D A, P3D B)
        {
            return A.x * B.x + A.y * B.y + A.z * B.z;
        }

        public double N2()
        {
            return x * x + y * y + z * z;
        }

        public double N()
        {
            return Math.Sqrt(N2());
        }

        public override string ToString()
        {
            return $"({x} {y} {z})";
        }
    }
}
