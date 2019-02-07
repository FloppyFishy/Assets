using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mancontroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("TORSO_UPPER").GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
