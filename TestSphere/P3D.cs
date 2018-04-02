using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSphere
{
    public class P3D
    {
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

        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
    }
}
