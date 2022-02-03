using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIAlgorithms
{
    class Path
    {
        private string _name;
        private double _heuristic;
        private double _estimatedCost;
        private double _accumulatedCost;
        private List<Node> _nodes;

        /// Constructors
        public Path(Node root)
        {
            _nodes = new List<Node>();
            _nodes.Add(root);

        }
        public Path()
        {
            _nodes = new List<Node>();
        }

        ///Propreties
        public List<Node> Nodes
        {
            get
            {return _nodes;}
            set
            { _nodes = value; }
        }
        public String Name
        {
            get
            {
                _name = "";
                foreach (Node n in _nodes)

                    _name += n.Name;
                return _name;
            }
             set { _name = value;}

        }
        public double AccumulatedCost
        {
            get
            {
                _accumulatedCost = 0;
                for (int i = 1; i < Nodes.Count; i++)
                    for (int j = 0; j < Nodes.ElementAt(i - 1).Children.Length; j++)
                        if (Nodes.ElementAt(i).Name == Nodes.ElementAt(i - 1).Children[j].node.Name)
                        {
                            _accumulatedCost += Nodes.ElementAt(i - 1).Children[j].costToParent;
                            break;
                        }

                return _accumulatedCost;
            }
            set
            {

                _accumulatedCost = value;

                ; }
        }
        public double Heuristic
        {
            get
            {

                _heuristic = _nodes.Last().HeuristicValue;
                return _heuristic;
            }
            set
            {

                _heuristic = value;

                ;
            }
        }
        public double EstimatedCost
        {
            get
            {


                return this.Heuristic+this.AccumulatedCost;
            }
            set
            {

                _estimatedCost = value;

            }
        }
    }
}
