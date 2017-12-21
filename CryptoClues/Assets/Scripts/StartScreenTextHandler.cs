using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenTextHandler : MonoBehaviour {

    GameObject text;

	// Use this for initialization
	void Start () {

        text = GameObject.Find("Text");

        StartCoroutine(waiter());
	}
	
    //add text
    IEnumerator waiter()
    {
        text.GetComponent<UnityEngine.UI.Text>().text += "Initializing systems.... \n";
        yield return new WaitForSeconds(2.5F);

        text.GetComponent<UnityEngine.UI.Text>().text += "Systems ready \n";
        yield return new WaitForSeconds(1);

        text.GetComponent<UnityEngine.UI.Text>().text += "Loading puzzles  \n";
        for (int i = 0; i < 30; i++)
        {
            text.GetComponent<UnityEngine.UI.Text>().text += "Crypto: " + Random.Range(0, 3) + Random.Range(0, 3) + Random.Range(0, 3) + "\n";
            yield return new WaitForSeconds(0.01F);
        }
        text.GetComponent<UnityEngine.UI.Text>().text += "Puzzles ready  \n";
        yield return new WaitForSeconds(0.5F);

        text.GetComponent<UnityEngine.UI.Text>().text += "Building UI.... \n";
        yield return new WaitForSeconds(1.5F);

        text.GetComponent<UnityEngine.UI.Text>().text += "UI Ready \n";
        yield return new WaitForSeconds(1);

        text.GetComponent<UnityEngine.UI.Text>().text += "Booting main drive... \n";
        yield return new WaitForSeconds(2);

        text.GetComponent<UnityEngine.UI.Text>().text += "All systems ready \n";

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Game");
    }
}
