using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class button : MonoBehaviour {

    public Button butt, reset;

    // Use this for initialization
    void Start () {
        reset.gameObject.SetActive(false);
        butt.onClick.AddListener(startgame);
        reset.onClick.AddListener(resety);
    }
	
	// Update is called once per frame
	void Update () {
        GameObject.Find("best").GetComponent<Text>().text = "Best: " + PlayerPrefs.GetInt("best").ToString();

        if (PlayerPrefs.GetInt("best") == 30)
        {
            reset.gameObject.SetActive(true);
        }

        if (PlayerPrefs.GetInt("best") < 30)
        {
            reset.gameObject.SetActive(false);
        }
	}

    void startgame()
    {
        SceneManager.LoadScene("game");
    }

    void resety()
    {
        PlayerPrefs.SetInt("best", 0);
    }
}
