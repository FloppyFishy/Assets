﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manimateanimator : MonoBehaviour {

    public Animator anim;
    public GameObject confetti;

	// Use this for initialization
	void Start () {
        anim.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
    }
    
    void move1()
    {
        GameObject.Find("man").GetComponent<mannimate>().move1();
    }

    void move2()
    {
        GameObject.Find("man").GetComponent<mannimate>().move2();
    }

    void move3()
    {
        GameObject.Find("man").GetComponent<mannimate>().move3();
        anim.SetBool("up", false);
        anim.enabled = false;
        if(PlayerPrefs.GetInt("level") == 1)
        {
            GameObject.Find("Canva").GetComponent<buttongame>().done = false;
            GameObject.Find("Canva").GetComponent<buttongame>().itdone = false;
            confetti.SetActive(false);
            GameObject.Find("Canva").GetComponent<buttongame>().bum = true;
        } else if (PlayerPrefs.GetInt("level") == 2)
        {
            GameObject.Find("Canva").GetComponent<buttongame2>().done = false;
            GameObject.Find("Canva").GetComponent<buttongame2>().itdone = false;
            confetti.SetActive(false);
            GameObject.Find("Canva").GetComponent<buttongame2>().bum = true;
        }
        else if (PlayerPrefs.GetInt("level") == 3)
        {
            GameObject.Find("Canva").GetComponent<buttongame3>().done = false;
            GameObject.Find("Canva").GetComponent<buttongame3>().itdone = false;
            confetti.SetActive(false);
            GameObject.Find("Canva").GetComponent<buttongame3>().bum = true;
        }
        else if (PlayerPrefs.GetInt("level") == 0)
        {
            GameObject.Find("Canva").GetComponent<buttongameEndless>().done = false;
            GameObject.Find("Canva").GetComponent<buttongameEndless>().itdone = false;
            confetti.SetActive(false);
            GameObject.Find("Canva").GetComponent<buttongameEndless>().bum = true;
        }

    }

    public void moving()
    {
        if (PlayerPrefs.GetInt("level") == 0)
        {
            anim.enabled = true;
            anim.SetBool("up", true);
        }
        else if (PlayerPrefs.GetInt("level") == 1)
        {
            if (PlayerPrefs.GetInt("score") < 9)
            {
                anim.enabled = true;
                anim.SetBool("up", true);
            }
        }
        else if (PlayerPrefs.GetInt("level") == 2)
        {
            if (PlayerPrefs.GetInt("score") < 19)
            {
                anim.enabled = true;
                anim.SetBool("up", true);
            }
        }
        else if (PlayerPrefs.GetInt("level") == 3)
        {
            if (PlayerPrefs.GetInt("score") < 29)
            {
                anim.enabled = true;
                anim.SetBool("up", true);
            }
        }
    }
}
