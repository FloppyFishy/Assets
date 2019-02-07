using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class button : MonoBehaviour {

    public Button butt;

    // Use this for initialization
    void Start () {
        butt.onClick.AddListener(startgame);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void startgame()
    {
        SceneManager.LoadScene("game");
    }
}
