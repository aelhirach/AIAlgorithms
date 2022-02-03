using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AIAlgorithms
{
    public struct NodeCostPair
    {
        public Node node;
        public double costToParent;
    }

    public class Node
    {
      // attributs
      public NodeCostPair[] _children;
      public int _childCount;
      private String _name;
      bool isRoot = false;
      bool isGoal = false;
      public bool isTrap  = false;
      public VisitState _state;
      private double _heuristicValue;
      private System.Windows.Forms.PictureBox pb;
      // Properties
      public System.Windows.Forms.PictureBox PB {
          get { return pb; }
          set { pb = value; }
      }

      public VisitState State
      {
          get { return _state; }
          set { _state = value; }
      }

      public bool IsRoot
      {
          get { return isRoot; }
          set { isRoot = value; }
      }
      public bool IsGoal
      {
          get { return isGoal; }
          set { isGoal = value; }
      }
      public bool IsTrap
      {
          get { return isTrap; }
          set { isTrap = value; }
      }
      public double HeuristicValue {
          get { return _heuristicValue; }
          set { _heuristicValue = value; }
      }
      public NodeCostPair[] Children
      {
          get { return _children; }
          set { _children = value; }
      }
      public String Name
      {
          get { return _name; }
          set { _name = value; }
      }
      // Constructors
      public Node(String name)
      {
          this._name = name;
      }
      public Node(String name, int child_Length)
      {
          this._name = name;
          _childCount = 0;
          _children = new NodeCostPair[child_Length];

      }
      public Node(String name, int child_Length, double heuristic)
      {
          this._name = name;
          this._heuristicValue = heuristic;
          _childCount = 0;
          _children = new NodeCostPair[child_Length];

      }
      public void addChildNode(Node childNode)
      {
          childNode.State = VisitState.Unvisited;
          if (_childCount <= _children.Length)
          {

              var child = new NodeCostPair();
              child.node = childNode;
              this._children[_childCount] = child;
              //this.paths[_childCount] = this._name+child._name;
              _childCount++;


          }
      }





    }


    }
