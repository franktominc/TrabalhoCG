using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Model {
    class Polygon {
        private List<Edge> _edges;
        private short _faceNumber;  // 1 - Front, 2 - Top, 3 - Right, 4 - Left, 5 - Botton, 6 - Back


        public short FaceNumber{
            get { return _faceNumber; }
            set { _faceNumber = value; }
        }


        public List<Edge> Edges {
            get { return _edges; }
            set { _edges = value; }
        }

        public Polygon() {
            _edges = new List<Edge>();
        }

        public void AddEdge(Edge e) {
            _edges.Add(e);
        }
    }
}
