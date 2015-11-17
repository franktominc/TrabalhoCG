using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplication1.Model;
using WpfApplication1.Utils;

namespace WpfApplication1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var a = new Vertex(0,0,1);
            var b = new Vertex(1,0,1);
            var c = new Vertex(1,1,1);
            var d = new Vertex(0,1,1);
            var ee = new Vertex(0, 0, 0);
            var f = new Vertex(1, 0, 0);
            var g = new Vertex(1, 1, 0);
            var h = new Vertex(0, 1, 0);

            var A = new Edge(a, b);
            var B = new Edge(b, c);
            var C = new Edge(c, d);
            var D = new Edge(d, a);
            
            var E = new Edge(c, g);
            var F = new Edge(g, f);
            var G = new Edge(f, b);
            
            var H = new Edge(g, h);
            var I = new Edge(h, ee);
            var J = new Edge(ee, f);
            var K = new Edge(f,g);

            var L = new Edge(a, ee);
            var M = new Edge(ee, h);
            var N = new Edge(h, d);

         
            
           
            

            var P1 = new Model.Polygon();
            P1.AddEdge(A);
            P1.AddEdge(B);
            P1.AddEdge(C);
            P1.AddEdge(D);
            var P2 = new Model.Polygon();
            P2.AddEdge(E);
            P2.AddEdge(F);
            P2.AddEdge(G);
            P2.AddEdge(B);
            var P3 = new Model.Polygon();
            P3.AddEdge(H);
            P3.AddEdge(I);
            P3.AddEdge(J);
            P3.AddEdge(K);
            var P4 = new Model.Polygon();
            P4.AddEdge(L);
            P4.AddEdge(M);
            P4.AddEdge(N);
            P4.AddEdge(D);
            var P5 = new Model.Polygon();
            P5.AddEdge(C);
            P5.AddEdge(E);
            P5.AddEdge(H);
            P5.AddEdge(N);
            var P6 = new Model.Polygon();
            P6.AddEdge(A);
            P6.AddEdge(G);
            P6.AddEdge(J);
            P6.AddEdge(L);
            var solid = new Solid();
            solid.addPolygon(P1);
            solid.addPolygon(P2);
            solid.addPolygon(P3);
            solid.addPolygon(P4);
            solid.addPolygon(P5);
            solid.addPolygon(P6);
            var x = solid.AsMatrix();
            MatrixOperations.DebugMatrix(x);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            Window k = new Window();
            var cube = new Solid();
            
            MatrixOperations.DebugMatrix(cube.GeraCubo());
        }
    }
}
