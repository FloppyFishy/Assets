﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mannimate : MonoBehaviour {

    public GameObject man;
    public Animator anim;
    float step;
    bool moove1;
    bool moove2;

	// Use this for initialization
	void Start () {
        step = 100 * Time.deltaTime;
    }
	
	// Update is called once per frame
	void Update () {
        if (moove1 == true && man.transform.position != new Vector3(man.transform.position.x - 0.61F, man.transform.position.y + 0.535F, 0F))
        {
            transform.position = Vector3.Lerp(man.transform.position, new Vector3(man.transform.position.x - 0.61F, man.transform.position.y + 0.535F, 0F), Time.deltaTime * 2.7f);
        }
        if (moove2 == true && man.transform.position != new Vector3(man.transform.position.x - 0.81F, man.transform.position.y + 0.535F, 0F))
        {
            transform.position = Vector3.Lerp(man.transform.position, new Vector3(man.transform.position.x - 0.81F, man.transform.position.y + 0.535F, 0F), Time.deltaTime * 2.8f);
        }
	}

    public void move1()
    {
        moove1 = true;
        //transform.position = Vector3.Lerp(man.transform.position, new Vector3(man.transform.position.x - 0.643F, man.transform.position.y + 0.531F, 0F), Time.deltaTime * 2.0f);
    }

    public void move2()
    {
        moove1 = false;
        moove2 = true;
        //transform.position = Vector3.Lerp(man.transform.position, new Vector3(man.transform.position.x - 0.847F, man.transform.position.y + 0.531F, 0F), Time.deltaTime * 2.0f);
    }

    public void move3()
    {
        moove2 = false;
    }
}