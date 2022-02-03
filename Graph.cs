using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIAlgorithms
{
    class Graph
    {
    // attributs
    public int _count; // num of vertices
    private Node[] _vertices;
    // Proprerties
    public Node[] _vertices
    {
        get { return _vertices; }
        set { _vertices = value; }
    }
    // Constructors
    public Graph(int graph_Length)
    {
        _vertices = new Node[graph_Length];
        _count = 0;
    }
    // Methods
    public void addNode(Node n)
    {
        if(_count < _vertices.Length)
        {
            _vertices[_count] = n;
            _count++;
        }
        else
        {
            Console.WriteLine("graph full");
        }
    }
    public Node getGoal()
    {
        Node goal = null;
        foreach (Node n in this._vertices)

            if (n.IsGoal)
            {
                goal = n;
                break;
            }
        return goal;
    }
    public Node getRoot()
    {
        Node root = null;
        foreach (Node n in this._vertices)

            if (n.IsRoot)
            {
                root = n;
                break;
            }
        return root;
    }
    }
}
