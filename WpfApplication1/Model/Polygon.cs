using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Model {
    class Polygon {
        private List<Edge> _edges;

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
