using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AIAlgorithms
{
    public partial class Labyrinth : Form
    {
        Graph graph;
        public Graphics g = null;
        List<Node> nodeList;
        public Labyrinth()
        {   InitializeComponent();
            Initialize();
        }
        private Graph createNewGraph()
        {
            Graph g = new Graph(26);
            Node[] temp = new Node[26];
            temp[1] = new Node("A", 3);
            temp[2] = new Node("B", 4);
            temp[3] = new Node("C", 3);
            temp[4] = new Node("D", 4);
            temp[5] = new Node("E", 3);
            temp[6] = new Node("F", 3);
            temp[7] = new Node("H", 4);
            temp[8] = new Node("I", 4);
            temp[9] = new Node("J", 4); 
            temp[10] = new Node("K", 3);
            temp[11] = new Node("L", 3);
            temp[12] = new Node("M", 3);
            temp[13] = new Node("N", 4);
            temp[14] = new Node("O", 4);
            temp[15] = new Node("S", 3);
            temp[16] = new Node("Q", 4);
            temp[17] = new Node("R", 3);
            temp[18] = new Node("T", 3);
            temp[20] = new Node("V", 1);
            temp[21] = new Node("W", 1);
            temp[22] = new Node("X", 2);
            List<KeyValuePair<int, int>> tempList = new List<KeyValuePair<int, int>>();
            // int numero dans le tableau int nombre d'enfant
            tempList.Add(new KeyValuePair<int,int>(0,2));
            tempList.Add(new KeyValuePair<int, int>(19, 2));
            tempList.Add(new KeyValuePair<int, int>(23, 2));
            tempList.Add(new KeyValuePair<int, int>(24, 1));
            tempList.Add(new KeyValuePair<int, int>(25, 1));
            var rnd = new Random();
            tempList = tempList.OrderBy(x => rnd.Next()).ToList();
            temp[tempList.ElementAt(0).Key] = new Node("S", tempList.ElementAt(0).Value); temp[tempList.ElementAt(0).Key].IsRoot = true;
            temp[tempList.ElementAt(1).Key] = new Node("G", tempList.ElementAt(1).Value); temp[tempList.ElementAt(1).Key].IsGoal = true;
            temp[tempList.ElementAt(2).Key] = new Node("Y", tempList.ElementAt(2).Value); temp[tempList.ElementAt(2).Key].IsTrap=true; 
            temp[tempList.ElementAt(3).Key] = new Node("Z", tempList.ElementAt(3).Value); temp[tempList.ElementAt(3).Key].IsTrap=true;
            temp[tempList.ElementAt(4).Key] = new Node("U", tempList.ElementAt(4).Value); temp[tempList.ElementAt(4).Key].IsTrap = true;
            // S
            temp[0].addChildNode(temp[1]);
            temp[0].addChildNode(temp[6]);
            // A
            temp[1].addChildNode(temp[0]);  
            temp[1].addChildNode(temp[2]);
            temp[1].addChildNode(temp[7]);
            // B
            temp[2].addChildNode(temp[1]);
            temp[2].addChildNode(temp[3]);
            temp[2].addChildNode(temp[7]);
            temp[2].addChildNode(temp[9]);
            //C
            temp[3].addChildNode(temp[2]);
            temp[3].addChildNode(temp[4]);
            temp[3].addChildNode(temp[9]);
            //D
            temp[4].addChildNode(temp[3]);
            temp[4].addChildNode(temp[9]);
            temp[4].addChildNode(temp[15]);
            temp[4].addChildNode(temp[10]);
            //E
            temp[5].addChildNode(temp[11]);
            temp[5].addChildNode(temp[19]);
            temp[5].addChildNode(temp[22]);
            //F
            temp[6].addChildNode(temp[0]);
            temp[6].addChildNode(temp[7]);
            temp[6].addChildNode(temp[12]);
            //H
            temp[7].addChildNode(temp[1]);
            temp[7].addChildNode(temp[2]);
            temp[7].addChildNode(temp[6]);
            temp[7].addChildNode(temp[1]);
            //I
            temp[8].addChildNode(temp[11]);
            temp[8].addChildNode(temp[14]);
            temp[8].addChildNode(temp[16]);
            temp[8].addChildNode(temp[23]);
            //J
            temp[9].addChildNode(temp[2]);
            temp[9].addChildNode(temp[3]);
            temp[9].addChildNode(temp[4]);
            temp[9].addChildNode(temp[14]);
            //K
            temp[10].addChildNode(temp[4]);
            temp[10].addChildNode(temp[11]);
            temp[10].addChildNode(temp[15]);
            //L
            temp[11].addChildNode(temp[5]);
            temp[11].addChildNode(temp[10]);
            temp[11].addChildNode(temp[25]);
            //M
            temp[12].addChildNode(temp[6]);
            temp[12].addChildNode(temp[17]);
            temp[12].addChildNode(temp[18]);

            //N
            temp[13].addChildNode(temp[7]);
            temp[13].addChildNode(temp[16]);
            temp[13].addChildNode(temp[17]);
            temp[13].addChildNode(temp[21]);
            //O
            temp[14].addChildNode(temp[8]);
            temp[14].addChildNode(temp[9]);
            temp[14].addChildNode(temp[15]);
            temp[14].addChildNode(temp[20]);
            //P
            temp[15].addChildNode(temp[4]);
            temp[15].addChildNode(temp[10]);
            temp[15].addChildNode(temp[14]);
            //Q
            temp[16].addChildNode(temp[8]);
            temp[16].addChildNode(temp[13]);
            temp[16].addChildNode(temp[17]);
            temp[16].addChildNode(temp[18]);

            //R
            temp[17].addChildNode(temp[12]);
            temp[17].addChildNode(temp[13]);
            temp[17].addChildNode(temp[16]);

            //T
            temp[18].addChildNode(temp[12]);
            temp[18].addChildNode(temp[16]);
            temp[18].addChildNode(temp[24]);

            //U
            temp[19].addChildNode(temp[5]);
            temp[19].addChildNode(temp[22]);

            //V
            temp[20].addChildNode(temp[14]);

            //W
            temp[21].addChildNode(temp[13]);

            //X
            temp[22].addChildNode(temp[19]);
            temp[22].addChildNode(temp[23]);

            //G
            temp[23].addChildNode(temp[8]);
            temp[23].addChildNode(temp[22]);

            //Y
            temp[24].addChildNode(temp[18]);

            //Z
            temp[25].addChildNode(temp[11]);
      

            for (int i = 0; i < temp.Length; i++)
            {
                g.addNode(temp[i]);
            }
            return g;
        }
        private void Initialize()
        {   
            gamePanel.Controls.Clear();
            g = gamePanel.CreateGraphics();
            graph = createNewGraph();
            nodeList = new List<Node>();
            for (int i = 1; i <= graph.Vertices.Length; i++)
            {   
                PictureBox pb = new PictureBox();
                pb.Name = "defaultPicture";
                pb.Size = new System.Drawing.Size(68, 58);
                pb.BorderStyle = BorderStyle.FixedSingle;
                //KeyValuePair<PictureBox, Node> pbNode = new KeyValuePair<PictureBox, Node>(pb, graph.Vertices[i - 1]);
                nodeList.Add(graph.Vertices[i - 1]);
                //pb7.Size = new System.Drawing.Size(68, 60);
                switch (i)
                {
                    case 1 : pb.Location = new System.Drawing.Point(24, 58); break;
                    case 2 : pb.Location = new System.Drawing.Point(169, 58); break;
                    case 3 : pb.Location = new System.Drawing.Point(344, 58); break;
                    case 4 : pb.Location = new System.Drawing.Point(524, 57); break;
                    case 5 : pb.Location = new System.Drawing.Point(636, 90); break;
                    case 6 : pb.Location = new System.Drawing.Point(827, 286); break;
                    case 7 : pb.Location = new System.Drawing.Point(59, 184); break;
                    case 8 : pb.Location = new System.Drawing.Point(203, 187); break;
                    case 9 : pb.Location = new System.Drawing.Point(498, 407); break;
                    case 10: pb.Location = new System.Drawing.Point(492, 167); break;
                    case 11: pb.Location = new System.Drawing.Point(706, 173); break;
                    case 12: pb.Location = new System.Drawing.Point(831, 178); break;
                    case 13: pb.Location = new System.Drawing.Point(104, 274); break;
                    case 14: pb.Location = new System.Drawing.Point(346, 264); break;
                    case 15: pb.Location = new System.Drawing.Point(488, 292); break;
                    case 16: pb.Location = new System.Drawing.Point(616, 279); break;
                    case 17: pb.Location = new System.Drawing.Point(233, 410); break;
                    case 18: pb.Location = new System.Drawing.Point(215, 305); break;
                    case 19: pb.Location = new System.Drawing.Point(106, 354); break;
                    case 20: pb.Location = new System.Drawing.Point(866, 460); break;
                    case 21: pb.Location = new System.Drawing.Point(392, 382); break;
                    case 22: pb.Location = new System.Drawing.Point(338, 160); break;
                    case 23: pb.Location = new System.Drawing.Point(715, 384); break;
                    case 24: pb.Location = new System.Drawing.Point(590, 458); break;
                    case 25: pb.Location = new System.Drawing.Point(105, 458); break;
                    case 26: pb.Location = new System.Drawing.Point(812, 25); break;
                    
                }

                graph.Vertices[i - 1].PB = pb;
                gamePanel.Controls.Add(pb);
                Label lblPB = new Label();
                lblPB.Font = new Font(lblPB.Font.FontFamily, 18, FontStyle.Bold);
                lblPB.Parent = pb;
                lblPB.Text = graph.Vertices[i - 1].Name;
                pb.Tag = graph.Vertices[i - 1].Name;
                pb.Controls.Add(lblPB);
                pb.BackColor = Color.Beige;
                pb.BorderStyle = BorderStyle.FixedSingle;
                FoundPathlabel.Text = "";

            }
           
            // Calculer la Valeur Heuristic et le coût 
            Node goal = graph.getGoal();
            goal.PB.BackgroundImage = AIAlgorithms.Properties.Resources.tresor;
            graph.getRoot().PB.BackgroundImage = AIAlgorithms.Properties.Resources.entrance;
            foreach (Node node in graph.Vertices)
            {
                //if (node.IsGoal) node.HeuristicValue = 0;
                 node.HeuristicValue = Distance(node, goal);
                
                for (int j = 0; j < node.Children.Length; j++)
                {
                    node.Children[j].costToParent = Distance(node, node.Children[j].node);
                } 
            }
            gamePanel.Enabled = false;

           
        }
        private Point MidPoint(Node a, Node b)
        {
            //double distance = Math.Sqrt(Math.Pow((b.PB.Location.X - a.PB.Location.X), 2) + Math.Pow((b.PB.Location.Y - b.PB.Location.X), 2));
            int dX = a.PB.Location.X + b.PB.Location.X;
            int dY = a.PB.Location.Y + b.PB.Location.Y;
            int X = dX / 2;
            int Y = dY / 2;
            double multi = dX * dX + dY * dY;
            Point midpoint = new Point(X, Y);

            return midpoint;
        }
        private void InitializePath()
        {

            FoundPathlabel.Text = "";
            label2.Text = "";
            //gamePanel.Invalidate();
            
            foreach (Node node in nodeList)
            {
                node.PB.BackColor = Color.Beige;
            }
            
            g = gamePanel.CreateGraphics();
            gamePanel.Refresh();
           
        }
        private double Distance(Node a, Node b)
        {
            //double distance = Math.Sqrt(Math.Pow((b.PB.Location.X - a.PB.Location.X), 2) + Math.Pow((b.PB.Location.Y - b.PB.Location.X), 2));
            double dX = a.PB.Location.X - b.PB.Location.X;
            double dY = a.PB.Location.Y - b.PB.Location.Y;
            double multi = dX * dX + dY * dY;
            return Math.Round(Math.Sqrt(multi), 2);
        }
        private void DFS_Click(object sender, EventArgs e)
        {
            InitializePath();
            g = gamePanel.CreateGraphics();
            SerachAlgorithms s = new SerachAlgorithms();
            Stack<Path> path = s.Dfs(graph.getRoot());
            foreach (Path p in path)
                FoundPathlabel.Text += p.Name + " ";
                label2.Text += path.Count.ToString();
            int pathLength = path.First().Nodes.Count;
            foreach (Node n in path.First().Nodes)
                for (int i = 1; i <= pathLength ; i++)
                {
                    path.First().Nodes[i - 1].PB.BackColor = Color.Green;
                    if (i < path.First().Nodes.Count)
                    {
                        Pen redPen = new Pen(Color.Black, 5);
                        Point p1 = new Point(path.First().Nodes[i].PB.Location.X, path.First().Nodes[i].PB.Location.Y);
                        Point p2 = new Point(path.First().Nodes[i - 1].PB.Location.X, path.First().Nodes[i - 1].PB.Location.Y);
                        g.DrawLine(redPen, p1, p2);
                        
                        Font f = new Font(Font.FontFamily, 15, FontStyle.Bold);
                        
                        int X = path.First().Nodes[i - 1].PB.Location.X;
                        int Y = path.First().Nodes[i - 1].PB.Location.Y - 20;
                        PointF point = new PointF(X, Y);
                        SolidBrush myBrush = new SolidBrush(Color.Red);
                        g.DrawString("H= "+ path.First().Nodes[i - 1].HeuristicValue.ToString(), f, myBrush, point);
 
                        if (i == pathLength - 1)
                        {   int xGoal = path.First().Nodes[i].PB.Location.X-20;
                            int yGoal = path.First().Nodes[i].PB.Location.Y - 20;
                            int X2 = path.First().Nodes[i - 1].PB.Location.X;
                            int Y2 = path.First().Nodes[i - 1].PB.Location.Y - 40;
                            PointF point2 = new PointF(X2, Y2);
                            PointF pointGoal = new PointF(xGoal, yGoal);
                            g.DrawString("H= "+path.First().Nodes[i].HeuristicValue.ToString(), f, myBrush, pointGoal);
                            SolidBrush myBrushf3 = new SolidBrush(Color.DarkViolet);
                            pointGoal.X += 40;
                            g.DrawString("AC= " + path.First().AccumulatedCost.ToString(), f, myBrushf3, pointGoal);


                        }

                    }

                    
                }

        }
        private void BFS_Click(object sender, EventArgs e)
        {

            InitializePath();
            g = gamePanel.CreateGraphics();
            SerachAlgorithms s = new SerachAlgorithms();
            Queue<Path> path = s.Bfs(graph.getRoot());
            for (int j = path.Count-1; j >=0 ; j--)
                FoundPathlabel.Text += path.ElementAt(j).Name +" ";
                label2.Text += path.Count.ToString();
            foreach (Node n in path.Last().Nodes)
                
                for (int i = 1; i <= path.Last().Nodes.Count; i++)
                {

                    if (i < path.Last().Nodes.Count)
                    {

                        Pen redPen = new Pen(Color.Black, 5);
                        
                        Point p1 = new Point(path.Last().Nodes[i].PB.Location.X, path.Last().Nodes[i].PB.Location.Y);
                        Point p2 = new Point(path.Last().Nodes[i - 1].PB.Location.X, path.Last().Nodes[i - 1].PB.Location.Y);
                        g.DrawLine(redPen, p1, p2);
                        
                        Font f = new Font(Font.FontFamily, 12, FontStyle.Bold);
                        int X= path.Last().Nodes[i - 1].PB.Location.X;
                        int Y= path.Last().Nodes[i - 1].PB.Location.Y-20;
                        PointF point = new PointF(X, Y);
                        SolidBrush myBrush = new SolidBrush(Color.Red);
                        g.DrawString("H=" + path.Last().Nodes[i - 1].HeuristicValue.ToString(), f, myBrush, point);
                        if (i == path.Last().Nodes.Count - 1)
                        {
                            int xGoal = path.Last().Nodes[i].PB.Location.X-20;
                            int yGoal = path.Last().Nodes[i].PB.Location.Y - 20;
                            PointF pointGoal = new PointF(xGoal, yGoal);
                            g.DrawString(path.Last().Nodes[i].HeuristicValue.ToString(), f, myBrush, pointGoal);
                            SolidBrush myBrushf3 = new SolidBrush(Color.DarkViolet);
                            pointGoal.X += 40;
                            g.DrawString("AC= " + path.Last().AccumulatedCost.ToString(), f, myBrushf3, pointGoal);
                            
                        }

                    }
                   
                    
                    path.Last().Nodes[i - 1].PB.BackColor = Color.Green;
                }
               
              
        }
        private void BeamSearch_Click(object sender, EventArgs e)
        {
            InitializePath();
            g = gamePanel.CreateGraphics();
            SerachAlgorithms s = new SerachAlgorithms();
            try
            {
                int beamWidth = int.Parse(beamWidthTextBox.Text);
                FoundPathlabel.Text = "";
                List<Path> path = s.BeamSearch(graph.getRoot(), beamWidth);
                foreach (Path p in path)
                    FoundPathlabel.Text += path.First().Name + ":" + path.First().Heuristic + "  ";
                    label2.Text += path.Count.ToString();
                for (int i = 1; i <= path.First().Nodes.Count; i++)
                {

                    if (i < path.First().Nodes.Count)
                    {

                        Pen redPen = new Pen(Color.Black, 5);
                        Point p1 = new Point(path.First().Nodes[i].PB.Location.X, path.First().Nodes[i].PB.Location.Y);
                        Point p2 = new Point(path.First().Nodes[i - 1].PB.Location.X, path.First().Nodes[i - 1].PB.Location.Y);
                        g.DrawLine(redPen, p1, p2);
                        PointF midpoint = MidPoint(path.First().Nodes[i], path.First().Nodes[i - 1]);
                        double distance = Distance(path.First().Nodes[i], path.First().Nodes[i - 1]);
                        Font f1 = new Font(Font.FontFamily, 10, FontStyle.Bold);
                        SolidBrush myBrushf1 = new SolidBrush(Color.Blue);
                        g.DrawString(distance.ToString(), f1, myBrushf1, midpoint);

                        Font f2 = new Font(Font.FontFamily, 12, FontStyle.Bold);
                        int X = path.First().Nodes[i - 1].PB.Location.X;
                        int Y = path.First().Nodes[i - 1].PB.Location.Y - 20;
                        PointF point = new PointF(X, Y);
                        SolidBrush myBrushf2 = new SolidBrush(Color.Red);
                        g.DrawString("H=" + path.First().Nodes[i - 1].HeuristicValue.ToString(), f2, myBrushf2, point);
                        if (i == path.First().Nodes.Count - 1)
                        {
                            int xGoal = path.First().Nodes[i].PB.Location.X - 20;
                            int yGoal = path.First().Nodes[i].PB.Location.Y - 20;
                            PointF pointGoal = new PointF(xGoal, yGoal);
                            g.DrawString("H=" + path.First().Nodes[i].HeuristicValue.ToString(), f2, myBrushf2, pointGoal);
                            SolidBrush myBrushf3 = new SolidBrush(Color.DarkViolet);
                            pointGoal.X += 40;
                            g.DrawString("AC= " + path.First().AccumulatedCost.ToString(), f2, myBrushf3, pointGoal);
                        }

                    }

                    path.First().Nodes[i - 1].PB.BackColor = Color.Red;
                }
            }
            catch { MessageBox.Show("Entrer un largeur de recherche valide"); }
           
        }
        private void GreedySearch_Click(object sender, EventArgs e)
        {
            
            InitializePath();
            g = gamePanel.CreateGraphics();
            SerachAlgorithms s = new SerachAlgorithms();
            List<Path> path = s.GreedySearch(graph.getRoot());
            foreach(Path p in path)
            FoundPathlabel.Text += p.Name+":"+p.Heuristic+ "  ";
            label2.Text += path.Count.ToString();
            foreach (Node n in path.First().Nodes)
                for (int i = 1; i <= path.First().Nodes.Count; i++)
                {

                    if (i < path.First().Nodes.Count)
                    {

                        Pen redPen = new Pen(Color.Black, 5);
                        Point p1 = new Point(path.First().Nodes[i].PB.Location.X, path.First().Nodes[i].PB.Location.Y);
                        Point p2 = new Point(path.First().Nodes[i - 1].PB.Location.X, path.First().Nodes[i - 1].PB.Location.Y);
                        g.DrawLine(redPen, p1, p2);
                        PointF midpoint = MidPoint(path.First().Nodes[i], path.First().Nodes[i - 1]);
                        double distance = Distance(path.First().Nodes[i], path.First().Nodes[i - 1]);
                        Font f1 = new Font(Font.FontFamily, 10, FontStyle.Bold);
                        SolidBrush myBrushf1 = new SolidBrush(Color.Blue);
                        g.DrawString(distance.ToString(), f1, myBrushf1, midpoint);

                        Font f2 = new Font(Font.FontFamily, 12, FontStyle.Bold);
                        int X = path.First().Nodes[i - 1].PB.Location.X;
                        int Y = path.First().Nodes[i - 1].PB.Location.Y - 20;
                        PointF point = new PointF(X, Y);
                        SolidBrush myBrushf2 = new SolidBrush(Color.Red);
                        g.DrawString("H="+ path.First().Nodes[i - 1].HeuristicValue.ToString(), f2, myBrushf2, point);
                        if (i == path.First().Nodes.Count - 1)
                        {
                            int xGoal = path.First().Nodes[i].PB.Location.X-20;
                            int yGoal = path.First().Nodes[i].PB.Location.Y - 20;
                            PointF pointGoal = new PointF(xGoal, yGoal);
                            g.DrawString("H="+ path.First().Nodes[i].HeuristicValue.ToString(), f2, myBrushf2, pointGoal);
                            SolidBrush myBrushf3 = new SolidBrush(Color.DarkViolet);
                            pointGoal.X += 40;
                            g.DrawString("AC= " + path.First().AccumulatedCost.ToString(), f2, myBrushf3, pointGoal);
                        }




                    }

                    path.First().Nodes[i - 1].PB.BackColor = Color.Green;
                }
        }
        private void EUCBB_Click(object sender, EventArgs e)
        {   
            InitializePath();
            g = gamePanel.CreateGraphics();
            SerachAlgorithms s = new SerachAlgorithms();
            List<Path> path = s.ExtendedUniformCostBB(graph.getRoot());
            foreach(Path p in path)
            FoundPathlabel.Text += p.Name+":"+p.Heuristic+ "  ";
            label2.Text += path.Count.ToString();
            foreach (Node n in path.First().Nodes)
                for (int i = 1; i <= path.First().Nodes.Count; i++)
                {

                    if (i < path.First().Nodes.Count)
                    {

                        Pen redPen = new Pen(Color.Black, 5);
                        Point p1 = new Point(path.First().Nodes[i].PB.Location.X, path.First().Nodes[i].PB.Location.Y);
                        Point p2 = new Point(path.First().Nodes[i - 1].PB.Location.X, path.First().Nodes[i - 1].PB.Location.Y);
                        g.DrawLine(redPen, p1, p2);
                        PointF midpoint = MidPoint(path.First().Nodes[i], path.First().Nodes[i - 1]);
                        double distance = Distance(path.First().Nodes[i], path.First().Nodes[i - 1]);
                        Font f1 = new Font(Font.FontFamily, 10, FontStyle.Bold);
                        SolidBrush myBrushf1 = new SolidBrush(Color.Blue);
                        g.DrawString(distance.ToString(), f1, myBrushf1, midpoint);

                        Font f2 = new Font(Font.FontFamily, 12, FontStyle.Bold);
                        int X = path.First().Nodes[i - 1].PB.Location.X;
                        int Y = path.First().Nodes[i - 1].PB.Location.Y - 20;
                        PointF point = new PointF(X, Y);
                        SolidBrush myBrushf2 = new SolidBrush(Color.Red);
                        g.DrawString("H= "+ path.First().Nodes[i - 1].HeuristicValue.ToString(), f2, myBrushf2, point);
                        if (i == path.First().Nodes.Count - 1)
                        {
                            int xGoal = path.First().Nodes[i].PB.Location.X-20;
                            int yGoal = path.First().Nodes[i].PB.Location.Y - 20;
                            PointF pointGoal = new PointF(xGoal, yGoal);
                            g.DrawString("H= "+  path.First().Nodes[i].HeuristicValue.ToString(), f2, myBrushf2, pointGoal);
                            SolidBrush myBrushf3 = new SolidBrush(Color.DarkViolet);
                            pointGoal.X += 40;
                            g.DrawString("AC= "+ path.First().AccumulatedCost.ToString(), f2, myBrushf3, pointGoal);
                            
                        }

                   


                    }

                    path.First().Nodes[i - 1].PB.BackColor = Color.Green;
                }
        
        }
        private void InitializeButton_Click(object sender, EventArgs e)
        {
            InitializePath();
            Initialize();
        }
        private void return_bt_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            // show other form
            Main main = new Main();
            main.ShowDialog();

            // close application
            this.Close();
        }


    }
}
