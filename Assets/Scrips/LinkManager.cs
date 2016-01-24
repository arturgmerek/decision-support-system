using UnityEngine;
using System.Collections;

public class LinkManager : MonoBehaviour {

    public GameObject linkTextMesh;
    public int linkValue;

    void Start()
    {
        linkValue = 0;
    }

    void Update() 
    {
        TextMesh tm = linkTextMesh.GetComponent<TextMesh>();
        tm.text = linkValue.ToString();
    }

    public void increaseValue()
    {
        linkValue += 1;
    }

    public void decreaseValue()
    {
        if (linkValue > 0) linkValue -= 1;
    }

}
