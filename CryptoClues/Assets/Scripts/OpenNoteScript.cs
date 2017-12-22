using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNoteScript : MonoBehaviour {

    void OnMouseDown()
    {
        MainGameHandler.noteBlank.SetActive(true);
    }

    void OnMouseUp()
    {
        MainGameHandler.noteBlank.SetActive(false);
    }
}
