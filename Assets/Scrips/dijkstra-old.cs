﻿using System.Collections.Generic;

namespace Graph_Algorithmn
{
    public class dijstra
    {
        List<int> queue = new List<int>();
        public double[] dist { get; set; }

        public dijstra(double[,] G, int s)
        {
            initial(0, s);
            while (queue.Count > 0)
            {
                int u = getNextVertex();
                for (int i = 0; i < s; i++)
                {
                    if (G[u, i] > 0)
                    {
                        if (dist[i] > dist[u] + G[u, i])
                        {
                            dist[i] = dist[u] + G[u, i];
                        }
                    }
                }
            }
        }

        public void initial(int s, int len)
        {
            dist = new double[len];
 
            for (int i = 0; i < len; i++)
            {
                dist[i] = double.PositiveInfinity;
                queue.Add(i);
            }
            dist[0] = 0;
        }

        int getNextVertex()
        {
            var min = double.PositiveInfinity;
            int vertex = -1;
 
            foreach (int val in queue)
            {
                if (dist[val] <= min)
                {
                    min = dist[val];
                    vertex = val;
                }
            }
            queue.Remove(vertex);
            return vertex;
        }
    }
 /*
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ListBox listBox = new ListBox();
            double[,] G = new double[4, 4];
            G[0, 1] = 3;
            G[0, 3] = 6;
            G[1, 3] = 1;
            G[1, 2] = 3;
            G[3, 2] = 1;
            dijstra dist = new dijstra(G, 4);
            var item = dist.dist;
            for (int i = 0; i < item.Length; i++)
            {
                listBox.Items.Add("Node " + i + " Path Distance = " + item[i]);
            }
            listBox.Width = this.Width;
            listBox.Height = this.Height;
            this.Controls.Add(listBox);
        }
    }*/
}