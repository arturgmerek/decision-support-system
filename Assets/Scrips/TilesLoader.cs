using UnityEngine;
using System.Collections;

public class TilesLoader : MonoBehaviour {

    public GameObject tilePrefab;

	void Start () {
        for (int y = -5; y < 6; y++)
        {
            for (int x = -7; x < 8; x++)
            {
                Instantiate(tilePrefab, new Vector3(x, y, -0.5f), Quaternion.identity);
            }
        }
	}
}
