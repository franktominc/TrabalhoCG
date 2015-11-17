using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WpfApplication1.Utils;

namespace WpfApplication1.Model {
    class Solid {
        private List<Polygon> _polygons;

        public List<Polygon> Polygons {
            get { return _polygons; }
            set { _polygons = value; }
        }

        public Solid() {
            _polygons = new List<Polygon>();
        }

        public Solid(List<Polygon> polygons) {
            _polygons = polygons;
        }

        public void addPolygon(Polygon p) {
            _polygons.Add(p);
        }

        public double[,] AsMatrix() {
            var k = _polygons.Count;
            var points = new double[k * 4, 4];
            var i = 0;
            foreach (var edge in Polygons.SelectMany(polygon => polygon.Edges)) {
                points[i, 0] = edge.StartVertex.X;
                points[i, 1] = edge.StartVertex.Y;
                points[i, 2] = edge.StartVertex.Z;
                points[i++, 3] = 1;
            }

            return MatrixOperations.TransposeMatrix(points);

        }

        public double[,] GeraCubo() {

            var a = new Vertex(0, 0, 1);
            var b = new Vertex(1, 0, 1);
            var c = new Vertex(1, 1, 1);
            var d = new Vertex(0, 1, 1);
            var ee = new Vertex(0, 0, 0);
            var f = new Vertex(1, 0, 0);
            var g = new Vertex(1, 1, 0);
            var h = new Vertex(0, 1, 0);

            var A = new Edge(a, b);
            var B = new Edge(b, c);
            var C = new Edge(c, d);
            var D = new Edge(d, a);
            var E = new Edge(f, ee);
            var F = new Edge(ee, h);
            var G = new Edge(h, g);
            var H = new Edge(g, f);
            var I = new Edge(b, f);
            var J = new Edge(g, c);
            var K = new Edge(ee, a);
            var L = new Edge(d, h);

            var P1 = new Model.Polygon();
            P1.AddEdge(A);
            P1.AddEdge(B);
            P1.AddEdge(C);
            P1.AddEdge(D);
            P1.FaceNumber = 1;
            var P2 = new Model.Polygon();
            P2.AddEdge(C);
            P2.AddEdge(L);
            P2.AddEdge(G);
            P2.AddEdge(J);
            P2.FaceNumber = 2;
            var P3 = new Model.Polygon();
            P3.AddEdge(B);
            P3.AddEdge(J);
            P3.AddEdge(H);
            P3.AddEdge(I);
            P3.FaceNumber = 3;
            var P4 = new Model.Polygon();
            P4.AddEdge(D);
            P4.AddEdge(K);
            P4.AddEdge(F);
            P4.AddEdge(L);
            P4.FaceNumber = 4;
            var P5 = new Model.Polygon();
            P5.AddEdge(E);
            P5.AddEdge(I);
            P5.AddEdge(A);
            P5.AddEdge(K);
            P5.FaceNumber = 5;
            var P6 = new Model.Polygon();
            P6.AddEdge(H);
            P6.AddEdge(E);
            P6.AddEdge(F);
            P6.AddEdge(G);
            P6.FaceNumber = 6;

            var solid = new Solid();
            solid.addPolygon(P1);
            solid.addPolygon(P2);
            solid.addPolygon(P3);
            solid.addPolygon(P4);
            solid.addPolygon(P5);
            solid.addPolygon(P6);
            var x = solid.AsMatrix();
            return x;
        }

    }
}
