using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishystart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void starting()
    {
        GameObject.Find("Canvas (2)").SetActive(false);
    }
}
