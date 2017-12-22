using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameHandler : MonoBehaviour {

    //define global variables
    LevelHandler levels = new LevelHandler();
    public static GameObject noteBlank;
    int currentLevel = 0;

    //start
	void Start () {
        noteBlank = GameObject.Find("noteBlank");
        noteBlank.SetActive(false);

        StartNewLevel();
	}
	
    //start new level
    public void StartNewLevel()
    {
       // noteBlank.GetComponent<UnityEngine.UI.Text>().text = levels.levels[0].clue;
    }

	//update
	void Update () {
		
	}
}
