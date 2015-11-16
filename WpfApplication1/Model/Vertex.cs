using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Model {
    public class Vertex {
        private double _x;
        private double _y;
        private double _z;

        public double Z{
            get { return _z; }
            set { _z = value; }
        }

        public double Y {
            get { return _y; }
            set { _y = value; }
        }

        public double X{
            get { return _x; }
            set { _x = value; }
        }

        public Vertex() {
        }

        public Vertex(double x, double y, double z) {
            _x = x;
            _y = y;
            _z = z;
        }

        public override string ToString() {
            return string.Format("({0},{1},{2})",X,Y,Z);
        }
    }
}
