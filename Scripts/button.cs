using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class button : MonoBehaviour {

    public Button butt, reset, endless;

    // Use this for initialization
    void Start () {
        butt.onClick.AddListener(startgame);
        reset.onClick.AddListener(resety);
        endless.onClick.AddListener(endlessy);
    }
	
	// Update is called once per frame
	void Update () {
        GameObject.Find("best").GetComponent<Text>().text = "Best: " + PlayerPrefs.GetInt("best").ToString();
        GameObject.Find("best (1)").GetComponent<Text>().text = "Best: " + PlayerPrefs.GetInt("best2").ToString();
    }

    void startgame()
    {
        SceneManager.LoadScene("game");
    }

    void endlessy()
    {
        SceneManager.LoadScene("endless");
    }

    void resety()
    {
        PlayerPrefs.SetInt("best", 0);
        PlayerPrefs.SetInt("best2", 0);
    }

    void resety2()
    {
        PlayerPrefs.SetInt("best2", 0);
    }
}
