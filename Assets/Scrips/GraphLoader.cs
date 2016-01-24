using UnityEngine;
using System.Collections;

public class GraphLoader : MonoBehaviour
{
    public GameObject nodePrefab;
    public GameObject linkPrefab;
    public GameObject crossLinkPrefab;

    void Start()
    {
        Instantiate(nodePrefab, new Vector3(-4, -4, -0.5f), Quaternion.identity);
        Instantiate(nodePrefab, new Vector3(-4, 4, -0.5f), Quaternion.identity);
        Instantiate(nodePrefab, new Vector3(4, -4, -0.5f), Quaternion.identity);
        Instantiate(nodePrefab, new Vector3(4, 4, -0.5f), Quaternion.identity);

        Instantiate(linkPrefab, new Vector3(4, 0, -0.5f), Quaternion.identity);
        Instantiate(linkPrefab, new Vector3(-4, 0, -0.5f), Quaternion.identity);
        Instantiate(linkPrefab, new Vector3(0, 4, -0.5f), Quaternion.Euler(0, 0, 90));
        Instantiate(linkPrefab, new Vector3(0, -4, -0.5f), Quaternion.Euler(0, 0, -90));

        Instantiate(crossLinkPrefab, new Vector3(0, 0, -0.5f), Quaternion.Euler(0, 0, 45));
        Instantiate(crossLinkPrefab, new Vector3(0, 0, -0.5f), Quaternion.Euler(0, 0, -45));
    }
}
