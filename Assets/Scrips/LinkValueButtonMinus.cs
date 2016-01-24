using UnityEngine;
using System.Collections;

public class LinkValueButtonMinus : MonoBehaviour
{
    public GameObject l;

    void OnMouseDown()
    {
        LinkManager linczek = l.GetComponent<LinkManager>();
        linczek.decreaseValue();
    }
}
