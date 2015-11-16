using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Model {
    class Edge {
        private Vertex _start;
        private Vertex _finish;

        public Vertex FinishVertex {
            get { return _finish; }
            set { _finish = value; }
        }

        public Vertex StartVertex {
            get { return _start; }
            set { _start = value; }
        }

        public Edge() {
        }

        public Edge(Vertex start, Vertex finish) {
            _start = start;
            _finish = finish;
        }
    }
}
