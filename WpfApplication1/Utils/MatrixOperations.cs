using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.Model;

namespace WpfApplication1.Utils {
    public static class MatrixOperations {
        private static double RAD = Math.PI / 180;
        public static double[,] MatrixMultiplication(double[,] a, double[,] b) {

            var c = new double[a.GetLength(0), b.GetLength(1)];
            var la = a.GetLength(0);
            var ca = a.GetLength(1);
            var lb = b.GetLength(0);
            var cb = b.GetLength(1);
            if (ca != lb) {
                Console.WriteLine("As matrizes possuem dimensoes incompativeis");
            }
            for (var i = 0; i < la; i++) {
                for (var j = 0; j < cb; j++) {
                    c[i, j] = 0;
                    for (var k = 0; k < ca; k++) {
                        c[i, j] = c[i, j] + (a[i, k] * b[k, j]);
                    }
                }
            }
            return c;
        }

        public static double[,] Translation(double x, double y, double z) {
            return new double[,] { { 1, 0, 0, x }, { 0, 1, 0, y }, { 0, 0, 1, z }, { 0, 0, 0, 1 } };
        }

        public static double[,] XAxisRotation(double angle) {
            var cosTheta = Math.Cos(RAD * angle);
            var sinTheta = Math.Sin(RAD * angle);
            return new[,] { { 1, 0, 0, 0 }, { 0, cosTheta, -sinTheta, 0 }, { 0, sinTheta, cosTheta, 0 }, { 0, 0, 0, 1 } };
        }
        public static double[,] YAxisRotation(double angle) {
            var cosTheta = Math.Cos(RAD * angle);
            var sinTheta = Math.Sin(RAD * angle);
            return new[,] { { cosTheta, 0, sinTheta, 0 }, { 0, 1, 0, 0 }, { -sinTheta, 0, cosTheta, 0 }, { 0, 0, 0, 1 } };
        }
        public static double[,] ZAxisRotation(double angle) {
            var cosTheta = Math.Cos(RAD * angle);
            var sinTheta = Math.Sin(RAD * angle);
            return new[,] { { cosTheta, -sinTheta, 0, 0 }, { sinTheta, cosTheta, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
        }

        public static double[,] Scale(double k) {
            return new double[,] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, k }, { 0, 0, 0, 1 } };
        }

        public static Vertex NormalizeVector(Vertex x) {
            var module = Math.Sqrt(x.X*x.X + x.Y*x.Y + x.Z*x.Z);
            return new Vertex(x.X/module, x.Y/module, x.Z/module);
        }

        public static Vertex CrossProduct(Vertex a, Vertex b) {
            var x = new Vertex(a.Y*b.Z-a.Z*b.Y,
                                  a.Z*b.X-b.Z*a.X,
                                  a.X*b.Y-a.Y*b.X);
            x = NormalizeVector(x);
            return x;
        }

        public static double DotProduct(Vertex a, Vertex b) {
            return a.X*b.X + a.Y*b.Y + a.Z*b.Z;
        }
    }
}
