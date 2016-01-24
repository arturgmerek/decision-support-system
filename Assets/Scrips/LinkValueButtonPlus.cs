using UnityEngine;
using System.Collections;

public class LinkValueButtonPlus : MonoBehaviour
{
    public GameObject l;

    void OnMouseDown()
    {
        LinkManager linczek = l.GetComponent<LinkManager>();
        linczek.increaseValue();
    }
}
