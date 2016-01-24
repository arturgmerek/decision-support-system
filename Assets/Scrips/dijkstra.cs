using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Dijkstra : MonoBehaviour {

    public GameObject nodeUno;
    public GameObject nodeDos;
    public GameObject nodeTres;
    public GameObject nodeQuatro;
    public GameObject linkUnoDos;
    public GameObject linkUnoTres;
    public GameObject linkUnoQuatro;
    public GameObject linkDosTres;
    public GameObject linkDosQuatro;
    public GameObject linkTresQuatro;

    public int distance;
    List<int> queue;
    double[] dist;
    double[,] G;

	void Start () 
    {
        G = new double[4, 4];
        queue = new List<int>();
        distance = new int();
        dist = new double[4];
	}

	void Update () 
    {
        loadObjects();
        initial();
        while (queue.Count > 0)
        {
            int u = getNextVertex();
            foreach (int i in queue)
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

        distance = 0;
        foreach (double d in dist)
        {
            distance += (int)d;
        }
	}

    private void loadObjects()
    {
        G[0, 1] = 3;
        G[0, 2] = 2;
        G[0, 3] = 6;

        G[1, 0] = 3;
        G[1, 2] = 3;
        G[1, 3] = 1;

        G[2, 0] = 2;
        G[2, 1] = 3;
        G[2, 3] = 1;

        G[3, 0] = 6;
        G[3, 1] = 1;
        G[3, 2] = 1;
    }

    void initial()
    {
        for (int i = 0; i < 4; i++)
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
