using UnityEngine;
using System.Collections;

public class TileManager : MonoBehaviour {

    public bool tileState;
    public int tilePath;
    Renderer rend;

    void Start() {
        tileState = false;
        tilePath = 99999;
    }

    void OnMouseDown()
    {
        tileState = !tileState;
        tilePath = tileState ? 1 : 99999;
        rend = this.GetComponent<Renderer>();
        rend.enabled = !rend.enabled;
    }

}
