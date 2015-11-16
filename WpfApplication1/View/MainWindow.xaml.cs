using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var a = new double[,] { {1,2,3}, {4,5,6}, {7,8,9}};
            var b = new double[,] { {1,2,3}, {4,5,6}, {7,8,9}};
            var c = Utils.MatrixOperations.MatrixMultiplication(a, b);
            for (int i = 0; i < c.GetLength(0); i++) {
                for (int j = 0; j < c.GetLength(1); j++) {
                    Console.Write("{0} ",c[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
