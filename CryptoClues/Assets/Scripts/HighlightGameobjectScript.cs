using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightGameobjectScript : MonoBehaviour {
    Color startColor = Color.white;
    bool showNote = false;

    void OnMouseEnter()
    {
        startColor = GetComponent<SpriteRenderer>().color;
        GetComponent<SpriteRenderer>().color = Color.gray;
    }

    void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = startColor;
    }
}
