using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace AIAlgorithms
{
    class SerachAlgorithms
    {
        // DFS Algorithm 
        public Stack<Path> Dfs(Node root)
        {
            if (root == null) return null;
            bool isGaol = false;
            //queue des chemins 
            var queue = new Stack<Path>();
            root.state = VisitState.Visited;
            //[(S)]
            //[S]
            queue.Push(new Path(root));
            while (queue.Any() && !isGaol)
            {   //[]-> S
                Path p = queue.Pop();
                //[]-> (S)
                foreach (NodeCostPair child in p.Nodes.Last().Children)
                {
                    if (!p.Name.Contains(child.node.Name))
                    {   //[SA|SD]
                        Path childPath = new Path();
                        childPath.Nodes.AddRange(p.Nodes);
                        childPath.Nodes.Add(child.node);
                        queue.Push(childPath);
                        //[(A)|(S)]

                        if (child.node.Name == "G")
                        {
                            isGaol = true;
                            break;
                        }
                    }
                }

            }
            return queue;
            
        }
        public Queue<Path> Bfs(Node root)
        {
            if (root == null) return null;
            bool isGaol = false;
            //queue des chemins 
            var queue = new Queue<Path>();
            root.state = VisitState.Visited;
            //[(S)]
            //[S]
            queue.Enqueue(new Path(root));
            while (queue.Any() && !isGaol)
            {   //[]-> S
                Path p = queue.Dequeue();
                //[]-> (S)
                foreach (NodeCostPair child in p.Nodes.Last().Children)
                {
                    if (!p.Name.Contains(child.node.Name))
                    {   //[SA|SD]
                        Path childPath = new Path();
                        childPath.Nodes.AddRange(p.Nodes);
                        childPath.Nodes.Add(child.node);
                        queue.Enqueue(childPath);
                        //[(A)|(S)]

                        if (child.node.Name == "G")
                        {
                            isGaol = true;
                            break;
                        }
                    }
                }

            }
            return queue;
            //Console.Write(queue.Last().Name);
        }
        public List<Path> BeamSearch(Node root,int width)
        {
            if (root == null) return null;
            bool isGaol = false;
            //queue des chemins 
            var queue = new List<Path>();
            root.state = VisitState.Visited;
            queue.Add(new Path(root));
            while (queue.Any() && !isGaol)
            {  //remove all paths from the QUEUE
                var tempQueue = new List<Path>();
                foreach (Path path in queue)
                    tempQueue.Add(path);
                queue.Clear();
                // create new paths (to all children)
                var tempChildPaths = new List<Path>();
                foreach (Path p in tempQueue)
                {
                    foreach (NodeCostPair child in p.Nodes.Last().Children)
                    {
                        //reject the new paths with loops
                        if (!p.Name.Contains(child.node.Name))
                        {   //creation du chemin
                            Path childPath = new Path();
                            childPath.Nodes.AddRange(p.Nodes);
                            childPath.Nodes.Add(child.node);
                            tempChildPaths.Add(childPath);
                            if (child.node.Name == "G")
                            {
                                isGaol = true;
                                goto Finish;
                            }
                        }
                    }
                    
                }

                //Optimisation : “remove the paths with no successors”
                // Parcourir la list des chemins enfants temporaire 
                for (int i = tempChildPaths.Count - 1; i >= 0; i--)
                 {
                     var tempChildWithoutLoop = new List<NodeCostPair>();
                     for (int j = 0; j < tempChildPaths[i].Nodes.Last().Children.Length; j++)
                     {
                         if (tempChildPaths[i].Nodes.Last().Children[j].node == null) break;
                         else if (!tempChildPaths[i].Name.Contains(tempChildPaths[i].Nodes.Last().Children[j].node.Name))
                             tempChildWithoutLoop.Add(tempChildPaths[i].Nodes.Last().Children[j]);
                     }
                     if (tempChildWithoutLoop.Count == 0)
                         tempChildPaths.Remove(tempChildPaths[i]);  
               }
            //take only width paths 
            Finish: ;
              tempChildPaths = tempChildPaths.OrderBy(o => o.Heuristic).ToList();
              queue = tempChildPaths.Take(width).ToList();       
            
            }
            return queue;
            //Console.Write(queue.Last().Name);
        }
        public List<Path> GreedySearch(Node root)
        {
            if (root == null) return null;
            bool isGaol = false;
            //queue des chemins 
            var queue = new List<Path>();
            root.state = VisitState.Visited;
            queue.Add(new Path(root));

            while (queue.Any() && !isGaol)
            {

                Path p = queue.First();
                queue.RemoveAt(0);
                List<Path> tempList = new List<Path>();
                foreach (NodeCostPair child in p.Nodes.Last().Children)
                { 
                    if (!p.Name.Contains(child.node.Name))
                    {   //[SA|SD]
                        Path childPath = new Path();
                        childPath.Nodes.AddRange(p.Nodes);
                        childPath.Nodes.Add(child.node);
                        tempList.Add(childPath);
                        //[(A)|(S)]
                        if (child.node.Name == "G")
                        {
                            isGaol = true;
                            goto Finish;
                        }

                    }

                }
                Finish:;
                queue.AddRange(tempList);
                queue = queue.OrderBy(o => o.Heuristic).ToList();
                        //[(A)|(S)]     
            }

            return queue;
            
        }
        public List<Path> ExtendedUniformCostBB(Node root)
        {
            if (root == null) return null;
            bool firstPathReachGaol = false;
            //queue des chemins 
            var queue = new List<Path>();
            root.state = VisitState.Visited;
            queue.Add(new Path(root));

            while (queue.Any() && !firstPathReachGaol)
            {

                Path p = queue.First();
                queue.RemoveAt(0);
                foreach (NodeCostPair child in p.Nodes.Last().Children)
                {
                    if (!p.Name.Contains(child.node.Name))
                    {   //[SA|SD]
                        Path childPath = new Path();
                        childPath.Nodes.AddRange(p.Nodes);
                        childPath.Nodes.Add(child.node);
                        queue.Add(childPath);
                        //[(A)|(S)]
                        queue = queue.OrderBy(o => o.EstimatedCostFonction).ToList();
                        //[(A)|(S)]
                        if (queue.First().Nodes.Last().Name == "G")
                        {
                            firstPathReachGaol = true;
                            break;
                        }
 
                    }

                }

            }

            return queue;
      
        }

        }
    }



    





    
   

    

