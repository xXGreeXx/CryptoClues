using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNoteScript : MonoBehaviour {

    void OnMouseDown()
    {
        MainGameHandler.noteBlank.SetActive(true);
        MainGameHandler.noteBlank.transform.Find("noteText").gameObject.GetComponent<UnityEngine.UI.InputField>().Select();
        MainGameHandler.noteBlank.transform.Find("noteText").gameObject.GetComponent<UnityEngine.UI.InputField>().ActivateInputField();
    }
}
