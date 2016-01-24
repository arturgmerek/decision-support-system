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

    public GameObject distanceTextMesh;

    int distance;
    TextMesh distanceText;
    List<int> queue;
    public double[] dist;
    double[,] G;

    LinkManager ud;
    LinkManager ut;
    LinkManager uq;
    LinkManager dt;
    LinkManager dq;
    LinkManager tq;

	void Start () 
    {
        G = new double[4, 4];
        queue = new List<int>();
        distance = new int();
        dist = new double[4];
        ud = linkUnoDos.GetComponent<LinkManager>();
        ut = linkUnoTres.GetComponent<LinkManager>();
        uq = linkUnoQuatro.GetComponent<LinkManager>();
        dt = linkDosTres.GetComponent<LinkManager>();
        dq = linkDosQuatro.GetComponent<LinkManager>();
        tq = linkTresQuatro.GetComponent<LinkManager>();
        distanceText = distanceTextMesh.GetComponent<TextMesh>();
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

        distanceText.text = "Shortest distance \nbetween nodes";
        distanceText.text += "\n1-2: " + dist[1].ToString();
        distanceText.text += "\n1-3: " + dist[2].ToString();
        distanceText.text += "\n1-4: " + dist[3].ToString();
	}

    private void loadObjects()
    {
        G[0, 1] = ud.linkValue;
        G[0, 2] = ut.linkValue;
        G[0, 3] = uq.linkValue;

        G[1, 0] = ud.linkValue;
        G[1, 2] = dt.linkValue;
        G[1, 3] = dq.linkValue;

        G[2, 0] = ut.linkValue;
        G[2, 1] = dt.linkValue;
        G[2, 3] = tq.linkValue;

        G[3, 0] = uq.linkValue;
        G[3, 1] = dq.linkValue;
        G[3, 2] = tq.linkValue;
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
