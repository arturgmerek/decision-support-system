using UnityEngine;
using System.Collections;

public class LinkManager : MonoBehaviour {

    public int tilePath;

    void Start() {
        tilePath = 1;
    }

    void OnMouseDown()
    {
        tilePath =+ 1;
    }

}
