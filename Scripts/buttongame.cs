﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttongame : MonoBehaviour {

    public Button butt1, butt2, butt3, butt4;
    public Button reset;
    public Button next;
    public Button menu;
    public GameObject stairy;
    public AudioSource aud;
    public GameObject manArmature;
    public GameObject manFloppy;
    public GameObject woArmature;
    public GameObject woFloppy;
    public GameObject cameras;
    public AudioClip win;
    public AudioClip lose;
    public AudioClip donit;
    public Animator anim;
    public GameObject confetti;
    public GameObject conf1;
    public GameObject failreason;
    public Text score;
    public bool done;
    int ansran;
    int oneitdone;
    bool yeah = false;
    bool yeah2 = false;
    bool yeah3 = false;
    bool yeah4 = false;
    bool yeah5 = false;
    bool yeah6 = false;
    bool yeah7 = false;
    bool yeah8 = false;
    bool yeah9 = false;
    bool failed = false;
    bool fin = false;
    bool fial;
    bool poopoo;
    bool camerafin;
    public bool itdone;
    public bool bum = true;
    public bool cheat;
    float timer;
    Vector3 camPos;
    Vector3 tempos;

    int temp1;
    int temp2;
    int temp3;
    int temp4;

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.GetInt("character") == 0)
        {
            manFloppy.SetActive(false);
            woFloppy.SetActive(false);
            manArmature.SetActive(true);
            woArmature.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("character") == 1)
        {
            manFloppy.SetActive(false);
            woFloppy.SetActive(false);
            manArmature.SetActive(false);
            woArmature.SetActive(true);
        }
        else
        {
            manFloppy.SetActive(false);
            woFloppy.SetActive(false);
            manArmature.SetActive(true);
            woArmature.SetActive(false);
        }

        if (PlayerPrefs.GetInt("level") == 1)
        {
            anim.SetBool("timelimitshow", false);
            failreason.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("level") == 2)
        {
            anim.SetBool("timelimitshow", true);
            failreason.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("level") == 3)
        {
            anim.SetBool("timelimitshow", true);
            failreason.SetActive(true);
        }
        else
        {
            anim.SetBool("timelimitshow", false);
            failreason.SetActive(false);
        }

        anim.SetBool("timelimitshow", true);
        anim.SetBool("winanim", false);

        camerafin = false;
        failed = false;
        done = false;
        fin = false;
        fial = false;

        reset.gameObject.SetActive(false);
        menu.gameObject.SetActive(false);
        next.gameObject.SetActive(false);
        conf1.SetActive(false);
        confetti.SetActive(false);

        aud = GameObject.Find("man").GetComponent<AudioSource>();
        stairy = GameObject.Find("stair");

        camPos = cameras.transform.position;

        manFloppy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        woFloppy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

        butt1.onClick.AddListener(isgood1);
        butt2.onClick.AddListener(isgood2);
        butt3.onClick.AddListener(isgood3);
        butt4.onClick.AddListener(isgood4);
        reset.onClick.AddListener(resety);
        next.onClick.AddListener(nexty);
        menu.onClick.AddListener(menuy);

        PlayerPrefs.SetInt("level", 1);
    }
	
	// Update is called once per frame
	void Update () {
        score.text = PlayerPrefs.GetInt("score").ToString();
        if (PlayerPrefs.GetInt("level") == 1)
        {
            if (PlayerPrefs.GetInt("score") == 0)
            {
                stairy = GameObject.Find("stair");
            }
            else if (PlayerPrefs.GetInt("score") == 1)
            {
                stairy = GameObject.Find("stair1");
                if (yeah == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah = true;
            }
            else if (PlayerPrefs.GetInt("score") == 2)
            {
                stairy = GameObject.Find("stair2");
                if (yeah2 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah2 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 3)
            {
                stairy = GameObject.Find("stair3");
                if (yeah3 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah3 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 4)
            {
                stairy = GameObject.Find("stair4");
                if (yeah4 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah4 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 5)
            {
                stairy = GameObject.Find("stair5");
                if (yeah5 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah5 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 6)
            {
                stairy = GameObject.Find("stair6");
                if (yeah6 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah6 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 7)
            {
                stairy = GameObject.Find("stair7");
                if (yeah7 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah7 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 8)
            {
                stairy = GameObject.Find("stair8");
                if (yeah8 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah8 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 9)
            {
                stairy = GameObject.Find("stair9");
                if (yeah9 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah9 = true;
            }
        }
        if (PlayerPrefs.GetInt("level") == 2)
        {
            if (timer == 20F && fial == false)
            {
                failreason.SetActive(true);
                fail();
                StopAllCoroutines();
                fial = true;
            }
            if (PlayerPrefs.GetInt("score") == 10)
            {
                stairy = GameObject.Find("stair");
            }
            else if (PlayerPrefs.GetInt("score") == 11)
            {
                stairy = GameObject.Find("stair1");
                if (yeah == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah = true;
            }
            else if (PlayerPrefs.GetInt("score") == 12)
            {
                stairy = GameObject.Find("stair2");
                if (yeah2 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah2 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 13)
            {
                stairy = GameObject.Find("stair3");
                if (yeah3 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah3 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 14)
            {
                stairy = GameObject.Find("stair4");
                if (yeah4 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah4 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 15)
            {
                stairy = GameObject.Find("stair5");
                if (yeah5 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah5 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 16)
            {
                stairy = GameObject.Find("stair6");
                if (yeah6 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah6 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 17)
            {
                stairy = GameObject.Find("stair7");
                if (yeah7 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah7 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 18)
            {
                stairy = GameObject.Find("stair8");
                if (yeah8 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah8 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 19)
            {
                stairy = GameObject.Find("stair9");
                if (yeah9 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah9 = true;
            }
        }
        if (PlayerPrefs.GetInt("level") == 3)
        {
            if (timer == 10F && fial == false)
            {
                failreason.SetActive(true);
                fail();
                StopAllCoroutines();
                fial = true;
            }
            if (PlayerPrefs.GetInt("score") == 20)
            {
                stairy = GameObject.Find("stair");
            }
            else if (PlayerPrefs.GetInt("score") == 21)
            {
                stairy = GameObject.Find("stair1");
                if (yeah == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah = true;
            }
            else if (PlayerPrefs.GetInt("score") == 22)
            {
                stairy = GameObject.Find("stair2");
                if (yeah2 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah2 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 23)
            {
                stairy = GameObject.Find("stair3");
                if (yeah3 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah3 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 24)
            {
                stairy = GameObject.Find("stair4");
                if (yeah4 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah4 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 25)
            {
                stairy = GameObject.Find("stair5");
                if (yeah5 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah5 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 26)
            {
                stairy = GameObject.Find("stair6");
                if (yeah6 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah6 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 27)
            {
                stairy = GameObject.Find("stair7");
                if (yeah7 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah7 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 28)
            {
                stairy = GameObject.Find("stair8");
                if (yeah8 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah8 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 29)
            {
                stairy = GameObject.Find("stair9");
                if (yeah9 == false)
                {
                    StartCoroutine(changebutt(0.6F));
                }
                yeah9 = true;
            }
        }

        if (PlayerPrefs.GetInt("score") == 10)
        {
            if (fin == false)
            {
                finish();
                fin = true;
            }
        }
        if (PlayerPrefs.GetInt("score") == 20)
        {
            if (fin == false)
            {
                finish();
                fin = true;
            }
        }
        if (PlayerPrefs.GetInt("score") == 30)
        {
            if (fin == false)
            {
                finish();
                fin = true;
            }
        }

        if (poopoo == true)
        {
            StopAllCoroutines();
            poopoo = false;
        }
	}

    private IEnumerator timey(float waitTime)
    {
        while (true)
        {
            if (failed == false)
            {
                yield return new WaitForSeconds(waitTime);
                timer++;
            }
            else
            {
                yield return null;
            }

        }
    }

    private IEnumerator poo(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            if (PlayerPrefs.GetInt("character") == 0)
            {
                manArmature.SetActive(false);
                manFloppy.SetActive(true);
                manFloppy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                manFloppy.GetComponent<Rigidbody2D>().AddForce((transform.right + new Vector3(0, -5, 0)) * -1000F);
            }
            else if (PlayerPrefs.GetInt("character") == 1)
            {
                woArmature.SetActive(false);
                woFloppy.SetActive(true);
                woFloppy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                woFloppy.GetComponent<Rigidbody2D>().AddForce((transform.right + new Vector3(0, -5, 0)) * -1000F);
            }
            else
            {
                manArmature.SetActive(false);
                manFloppy.SetActive(true);
                manFloppy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                manFloppy.GetComponent<Rigidbody2D>().AddForce((transform.right + new Vector3(0, -5, 0)) * -1000F);
            }
            poopoo = true;
        }
    }

    private IEnumerator changebutt(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        changeButton();
    }

    void menuy()
    {
        SceneManager.LoadScene("menu");
        if (PlayerPrefs.GetInt("best") < PlayerPrefs.GetInt("score"))
        {
            PlayerPrefs.SetInt("best", PlayerPrefs.GetInt("score"));
        }
    }

    void finish()
    {
        
        menu.gameObject.SetActive(true);
        next.gameObject.SetActive(true);
        aud.clip = win;
        aud.Play();
        itdone = true;
        StartCoroutine(poo(0.3F));
        //tempos = GameObject.Find("man").transform.position;
        conf1.SetActive(true);
        anim.SetBool("winanim", true);
        butt1.gameObject.GetComponentInChildren<Text>().text = "Yay!";
        butt2.gameObject.GetComponentInChildren<Text>().text = "Yay!";
        butt3.gameObject.GetComponentInChildren<Text>().text = "Yay!";
        butt4.gameObject.GetComponentInChildren<Text>().text = "Yay!";
    }

    void nexty()
    {
        if (PlayerPrefs.GetInt("level") == 1)
        {
            PlayerPrefs.SetInt("level", 2);
            SceneManager.LoadScene("game2");
        }
        else if (PlayerPrefs.GetInt("level") == 2)
        {
            PlayerPrefs.SetInt("level", 3);
            SceneManager.LoadScene("game3");
        }
        else if (PlayerPrefs.GetInt("level") == 3)
        {
            SceneManager.LoadScene("menu");
            if (PlayerPrefs.GetInt("best") < PlayerPrefs.GetInt("score"))
            {
                PlayerPrefs.SetInt("best", PlayerPrefs.GetInt("score"));
            }
        }
        else
        {
            PlayerPrefs.SetInt("level", 1);
            SceneManager.LoadScene("game");
        }
    }

    void changeButton()
    {
        Debug.Log("cahnaged the bnuttons");
        temp1 = Convert.ToInt32(butt1.GetComponentInChildren<Text>().text);
        temp2 = Convert.ToInt32(butt2.GetComponentInChildren<Text>().text);
        temp3 = Convert.ToInt32(butt3.GetComponentInChildren<Text>().text);
        temp4 = Convert.ToInt32(butt4.GetComponentInChildren<Text>().text);
        string[] temparr = stairy.GetComponentInChildren<Text>().text.Split(' ');
        int ans = 0;
        if (temparr[1] == "+")
        {
            ans = Convert.ToInt32(temparr[0]) + Convert.ToInt32(temparr[2]);
        }
        else if (temparr[1] == "x")
        {
            ans = Convert.ToInt32(temparr[0]) * Convert.ToInt32(temparr[2]);
        }
        else if (temparr[1] == "-")
        {
            ans = Convert.ToInt32(temparr[0]) - Convert.ToInt32(temparr[2]);
        }
        else if (temparr[1] == "÷")
        {
            ans = Convert.ToInt32(temparr[0]) / Convert.ToInt32(temparr[2]);
        }

        ansran = UnityEngine.Random.Range(1, 5);
        Debug.Log(ansran);

        if (ansran == 1)
        {
            oneitdone = 1;
            temparr = stairy.GetComponentInChildren<Text>().text.Split(' ');
            if (temparr[1] == "+")
            {
                butt1.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) + Convert.ToInt32(temparr[2])).ToString();
            }
            else if (temparr[1] == "x")
            {
                butt1.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) * Convert.ToInt32(temparr[2])).ToString();
            }
            else if (temparr[1] == "-")
            {
                butt1.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) - Convert.ToInt32(temparr[2])).ToString();
            }
            else if (temparr[1] == "÷")
            {
                butt1.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) / Convert.ToInt32(temparr[2])).ToString();
            }
        }
        else if (ansran == 2)
        {
            oneitdone = 2;
            temparr = stairy.GetComponentInChildren<Text>().text.Split(' ');
            if (temparr[1] == "+")
            {
                butt2.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) + Convert.ToInt32(temparr[2])).ToString();
            }
            else if (temparr[1] == "x")
            {
                butt2.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) * Convert.ToInt32(temparr[2])).ToString();
            }
            else if (temparr[1] == "-")
            {
                butt2.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) - Convert.ToInt32(temparr[2])).ToString();
            }
            else if (temparr[1] == "÷")
            {
                butt2.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) / Convert.ToInt32(temparr[2])).ToString();
            }
        }
        else if (ansran == 3)
        {
            oneitdone = 3;
            temparr = stairy.GetComponentInChildren<Text>().text.Split(' ');
            if (temparr[1] == "+")
            {
                butt3.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) + Convert.ToInt32(temparr[2])).ToString();
            }
            else if (temparr[1] == "x")
            {
                butt3.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) * Convert.ToInt32(temparr[2])).ToString();
            }
            else if (temparr[1] == "-")
            {
                butt3.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) - Convert.ToInt32(temparr[2])).ToString();
            }
            else if (temparr[1] == "÷")
            {
                butt3.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) / Convert.ToInt32(temparr[2])).ToString();
            }
        }
        else if (ansran == 4)
        {
            oneitdone = 4;
            temparr = stairy.GetComponentInChildren<Text>().text.Split(' ');
            if (temparr[1] == "+")
            {
                butt4.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) + Convert.ToInt32(temparr[2])).ToString();
            }
            else if (temparr[1] == "x")
            {
                butt4.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) * Convert.ToInt32(temparr[2])).ToString();
            }
            else if (temparr[1] == "-")
            {
                butt4.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) - Convert.ToInt32(temparr[2])).ToString();
            }
            else if (temparr[1] == "÷")
            {
                butt4.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) / Convert.ToInt32(temparr[2])).ToString();
            }
        }
        else
        {
            oneitdone = 1;
            temparr = stairy.GetComponentInChildren<Text>().text.Split(' ');
            if (temparr[1] == "+")
            {
                butt1.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) + Convert.ToInt32(temparr[2])).ToString();
            }
            else if (temparr[1] == "x")
            {
                butt1.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) * Convert.ToInt32(temparr[2])).ToString();
            }
            else if (temparr[1] == "-")
            {
                butt1.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) - Convert.ToInt32(temparr[2])).ToString();
            }
            else if (temparr[1] == "÷")
            {
                butt1.GetComponentInChildren<Text>().text = (Convert.ToInt32(temparr[0]) / Convert.ToInt32(temparr[2])).ToString();
            }
        }



        if (oneitdone == 1)
        {
            while (Convert.ToInt32(butt2.GetComponentInChildren<Text>().text) == temp2)
            {
                butt2.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt1.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
            while (Convert.ToInt32(butt3.GetComponentInChildren<Text>().text) == temp3)
            {
                butt3.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt1.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
            while (Convert.ToInt32(butt4.GetComponentInChildren<Text>().text) == temp4)
            {
                butt4.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt1.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }

            if (butt2.GetComponentInChildren<Text>().text == butt1.GetComponentInChildren<Text>().text)
            {
                butt2.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt2.GetComponentInChildren<Text>().text) + 1).ToString();
            }
            if (butt3.GetComponentInChildren<Text>().text == butt1.GetComponentInChildren<Text>().text)
            {
                butt3.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt3.GetComponentInChildren<Text>().text) + 1).ToString();
            }
            if (butt4.GetComponentInChildren<Text>().text == butt1.GetComponentInChildren<Text>().text)
            {
                butt4.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt4.GetComponentInChildren<Text>().text) + 1).ToString();
            }
        }
        else if (oneitdone == 2)
        {
            while (Convert.ToInt32(butt1.GetComponentInChildren<Text>().text) == temp1)
            {
                butt1.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt2.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
            while (Convert.ToInt32(butt3.GetComponentInChildren<Text>().text) == temp3)
            {
                butt3.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt2.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
            while (Convert.ToInt32(butt4.GetComponentInChildren<Text>().text) == temp4)
            {
                butt4.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt2.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
        }
        else if (oneitdone == 3)
        {
            while (Convert.ToInt32(butt1.GetComponentInChildren<Text>().text) == temp1)
            {
                butt1.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt3.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
            while (Convert.ToInt32(butt2.GetComponentInChildren<Text>().text) == temp2)
            {
                butt2.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt3.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
            while (Convert.ToInt32(butt4.GetComponentInChildren<Text>().text) == temp4)
            {
                butt4.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt3.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
        }
        else if (oneitdone == 4)
        {
            while (Convert.ToInt32(butt1.GetComponentInChildren<Text>().text) == temp1)
            {
                butt1.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt4.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
            while (Convert.ToInt32(butt2.GetComponentInChildren<Text>().text) == temp2)
            {
                butt2.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt4.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
            while (Convert.ToInt32(butt3.GetComponentInChildren<Text>().text) == temp3)
            {
                butt3.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt4.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
        }

        if (Convert.ToInt32(butt1.GetComponentInChildren<Text>().text) < 0)
        {
            butt1.GetComponentInChildren<Text>().text = "1";
        }
        if (Convert.ToInt32(butt2.GetComponentInChildren<Text>().text) < 0)
        {
            butt2.GetComponentInChildren<Text>().text = "1";
        }
        if (Convert.ToInt32(butt3.GetComponentInChildren<Text>().text) < 0)
        {
            butt3.GetComponentInChildren<Text>().text = "1";
        }
        if (Convert.ToInt32(butt4.GetComponentInChildren<Text>().text) < 0)
        {
            butt4.GetComponentInChildren<Text>().text = "1";
        }


        if (butt1.GetComponentInChildren<Text>().text == butt4.GetComponentInChildren<Text>().text)
        {
            butt1.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt1.GetComponentInChildren<Text>().text) + 1).ToString();
        }
        if (butt2.GetComponentInChildren<Text>().text == butt4.GetComponentInChildren<Text>().text)
        {
            butt2.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt2.GetComponentInChildren<Text>().text) + 1).ToString();
        }
        if (butt3.GetComponentInChildren<Text>().text == butt4.GetComponentInChildren<Text>().text)
        {
            butt3.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt3.GetComponentInChildren<Text>().text) + 1).ToString();
        }
        if (butt1.GetComponentInChildren<Text>().text == butt3.GetComponentInChildren<Text>().text)
        {
            butt1.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt1.GetComponentInChildren<Text>().text) + 1).ToString();
        }
        if (butt2.GetComponentInChildren<Text>().text == butt3.GetComponentInChildren<Text>().text)
        {
            butt2.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt2.GetComponentInChildren<Text>().text) + 1).ToString();
        }
        if (butt4.GetComponentInChildren<Text>().text == butt3.GetComponentInChildren<Text>().text)
        {
            butt4.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt4.GetComponentInChildren<Text>().text) + 1).ToString();
        }
        if (butt1.GetComponentInChildren<Text>().text == butt2.GetComponentInChildren<Text>().text)
        {
            butt1.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt1.GetComponentInChildren<Text>().text) + 1).ToString();
        }
        if (butt3.GetComponentInChildren<Text>().text == butt2.GetComponentInChildren<Text>().text)
        {
            butt3.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt3.GetComponentInChildren<Text>().text) + 1).ToString();
        }
        if (butt4.GetComponentInChildren<Text>().text == butt2.GetComponentInChildren<Text>().text)
        {
            butt4.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt4.GetComponentInChildren<Text>().text) + 1).ToString();
        }

        if (butt1.GetComponentInChildren<Text>().text != ans.ToString() && butt2.GetComponentInChildren<Text>().text != ans.ToString() && butt3.GetComponentInChildren<Text>().text != ans.ToString() && butt4.GetComponentInChildren<Text>().text != ans.ToString())
        {
            ansran = UnityEngine.Random.Range(1, 5);
            if (ansran == 1)
            {
                butt1.GetComponentInChildren<Text>().text = ans.ToString();
            }
            else if (ansran == 2)
            {
                butt2.GetComponentInChildren<Text>().text = ans.ToString();
            }
            else if (ansran == 3)
            {
                butt3.GetComponentInChildren<Text>().text = ans.ToString();
            }
            else if (ansran == 4)
            {
                butt4.GetComponentInChildren<Text>().text = ans.ToString();
            }
        }
    }

    void move()
    {
        itdone = true;
        aud.clip = donit;
        aud.Play();
        if (PlayerPrefs.GetInt("level") == 1)
        {
            if (bum == true && PlayerPrefs.GetInt("score") < 9)
            {
                anim.SetTrigger("buttonpress");
                bum = false;
            }
        }
        else if (PlayerPrefs.GetInt("level") == 2)
        {
            if (bum == true && PlayerPrefs.GetInt("score") < 19)
            {
                anim.SetTrigger("buttonpress");
                bum = false;
            }
        }
        else if (PlayerPrefs.GetInt("level") == 3)
        {
            if (bum == true && PlayerPrefs.GetInt("score") < 29)
            {
                anim.SetTrigger("buttonpress");
                bum = false;
            }
        }
        else
        {
            Debug.Log("error");
        }


        if (done == false)
        {
            if (PlayerPrefs.GetInt("character") == 0)
            {
                manArmature.GetComponent<manimateanimator>().moving();
            }
            else if (PlayerPrefs.GetInt("character") == 1)
            {
                woArmature.GetComponent<manimateanimator>().moving();
            }
            else
            {
                manArmature.GetComponent<manimateanimator>().moving();
            }
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 1);
        }
        done = true;
        confetti.SetActive(true);
    }

    void resety()
    {
        if (PlayerPrefs.GetInt("level") == 1)
        {
            SceneManager.LoadScene("game");
        }
        else if (PlayerPrefs.GetInt("level") == 2)
        {
            SceneManager.LoadScene("game2");
        }
        else if (PlayerPrefs.GetInt("level") == 3)
        {
            SceneManager.LoadScene("game3");
        }
        else
        {
            SceneManager.LoadScene("game");
        }
    }


    void fail()
    {
        itdone = true;
        if (cheat == false)
        {
            if (PlayerPrefs.GetInt("best") < PlayerPrefs.GetInt("score"))
            {
                PlayerPrefs.SetInt("best", PlayerPrefs.GetInt("score"));
            }
            cameras.GetComponent<SmoothCamera2D>().enabled = true;
            reset.gameObject.SetActive(true);
            menu.gameObject.SetActive(true);
            aud.clip = lose;
            aud.Play();
            failed = true;
            if (PlayerPrefs.GetInt("character") == 0)
            {
                manArmature.SetActive(false);
            }
            else if (PlayerPrefs.GetInt("character") == 1)
            {
                woArmature.SetActive(false);
            }
            else
            {
                manArmature.SetActive(false);
            }

            if (PlayerPrefs.GetInt("character") == 0)
            {
                manFloppy.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("character") == 1)
            {
                woFloppy.SetActive(true);
            }
            else
            {
                manFloppy.SetActive(true);
            }

            StartCoroutine(fallfail(1.5F));
            Debug.Log("failed");
            anim.SetBool("failanim", true);
        }

    }

    private IEnumerator fallfail(float waitTime)
    {
        while (true)
        {
            if (PlayerPrefs.GetInt("character") == 0)
            {
                if (cameras.transform.position.y > 0)
                {
                    manFloppy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    manFloppy.GetComponent<Rigidbody2D>().AddForce(transform.right * 800F);
                }
                else if (cameras.transform.position.y == 0)
                {
                    manFloppy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    manFloppy.GetComponent<Rigidbody2D>().AddForce(transform.right * 800F);
                }
                else
                {
                    yield return null;
                }
            }
            else if (PlayerPrefs.GetInt("character") == 1)
            {
                if (cameras.transform.position.y > 0)
                {
                    woFloppy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    woFloppy.GetComponent<Rigidbody2D>().AddForce(transform.right * 800F);
                }
                else if (cameras.transform.position.y == 0)
                {
                    woFloppy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    woFloppy.GetComponent<Rigidbody2D>().AddForce(transform.right * 800F);
                }
                else
                {
                    yield return null;
                }
            }
            else
            {
                if (cameras.transform.position.y > 0)
                {
                    manFloppy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    manFloppy.GetComponent<Rigidbody2D>().AddForce(transform.right * 800F);
                }
                else if (cameras.transform.position.y == 0)
                {
                    manFloppy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    manFloppy.GetComponent<Rigidbody2D>().AddForce(transform.right * 800F);
                }
                else
                {
                    yield return null;
                }
            }


            yield return new WaitForSeconds(waitTime);
        }
    }

    void isgood1()
    {
        if (itdone == false)
        {
            string[] temparr = stairy.GetComponentInChildren<Text>().text.Split(' ');
            if (temparr[1] == "+")
            {
                if (butt1.GetComponentInChildren<Text>().text == (Convert.ToInt32(temparr[0]) + Convert.ToInt32(temparr[2])).ToString())
                {
                    move();
                }
                else
                {
                    fail();
                }
            }
            else if (temparr[1] == "x")
            {
                if (butt1.GetComponentInChildren<Text>().text == (Convert.ToInt32(temparr[0]) * Convert.ToInt32(temparr[2])).ToString())
                {
                    move();
                }
                else
                {
                    fail();
                }
            }
            else if (temparr[1] == "-")
            {
                if (butt1.GetComponentInChildren<Text>().text == (Convert.ToInt32(temparr[0]) - Convert.ToInt32(temparr[2])).ToString())
                {
                    move();
                }
                else
                {
                    fail();
                }
            }
            else if (temparr[1] == "÷")
            {
                if (butt1.GetComponentInChildren<Text>().text == (Convert.ToInt32(temparr[0]) / Convert.ToInt32(temparr[2])).ToString())
                {
                    move();
                }
                else
                {
                    fail();
                }
            }
        }


    }
    void isgood2()
    {
        if (itdone == false)
        {
            string[] temparr = stairy.GetComponentInChildren<Text>().text.Split(' ');
            if (temparr[1] == "+")
            {
                if (butt2.GetComponentInChildren<Text>().text == (Convert.ToInt32(temparr[0]) + Convert.ToInt32(temparr[2])).ToString())
                {
                    move();
                }
                else
                {
                    fail();
                }
            }
            else if (temparr[1] == "x")
            {
                if (butt2.GetComponentInChildren<Text>().text == (Convert.ToInt32(temparr[0]) * Convert.ToInt32(temparr[2])).ToString())
                {
                    move();
                }
                else
                {
                    fail();
                }
            }
            else if (temparr[1] == "-")
            {
                if (butt2.GetComponentInChildren<Text>().text == (Convert.ToInt32(temparr[0]) - Convert.ToInt32(temparr[2])).ToString())
                {
                    move();
                }
                else
                {
                    fail();
                }
            }
            else if (temparr[1] == "÷")
            {
                if (butt2.GetComponentInChildren<Text>().text == (Convert.ToInt32(temparr[0]) / Convert.ToInt32(temparr[2])).ToString())
                {
                    move();
                }
                else
                {
                    fail();
                }
            }
        }
        
    }
    void isgood3()
    {
        if (itdone == false)
        {
            string[] temparr = stairy.GetComponentInChildren<Text>().text.Split(' ');
            if (temparr[1] == "+")
            {
                if (butt3.GetComponentInChildren<Text>().text == (Convert.ToInt32(temparr[0]) + Convert.ToInt32(temparr[2])).ToString())
                {
                    move();
                }
                else
                {
                    fail();
                }
            }
            else if (temparr[1] == "x")
            {
                if (butt3.GetComponentInChildren<Text>().text == (Convert.ToInt32(temparr[0]) * Convert.ToInt32(temparr[2])).ToString())
                {
                    move();
                }
                else
                {
                    fail();
                }
            }
            else if (temparr[1] == "-")
            {
                if (butt3.GetComponentInChildren<Text>().text == (Convert.ToInt32(temparr[0]) - Convert.ToInt32(temparr[2])).ToString())
                {
                    move();
                }
                else
                {
                    fail();
                }
            }
            else if (temparr[1] == "÷")
            {
                if (butt3.GetComponentInChildren<Text>().text == (Convert.ToInt32(temparr[0]) / Convert.ToInt32(temparr[2])).ToString())
                {
                    move();
                }
                else
                {
                    fail();
                }
            }
        }

        
    }
    void isgood4()
    {
        if (itdone == false)
        {
            string[] temparr = stairy.GetComponentInChildren<Text>().text.Split(' ');
            if (temparr[1] == "+")
            {
                if (butt4.GetComponentInChildren<Text>().text == (Convert.ToInt32(temparr[0]) + Convert.ToInt32(temparr[2])).ToString())
                {
                    move();
                }
                else
                {
                    fail();
                }
            }
            else if (temparr[1] == "x")
            {
                if (butt4.GetComponentInChildren<Text>().text == (Convert.ToInt32(temparr[0]) * Convert.ToInt32(temparr[2])).ToString())
                {
                    move();
                }
                else
                {
                    fail();
                }
            }
            else if (temparr[1] == "-")
            {
                if (butt4.GetComponentInChildren<Text>().text == (Convert.ToInt32(temparr[0]) - Convert.ToInt32(temparr[2])).ToString())
                {
                    move();
                }
                else
                {
                    fail();
                }
            }
            else if (temparr[1] == "÷")
            {
                if (butt4.GetComponentInChildren<Text>().text == (Convert.ToInt32(temparr[0]) / Convert.ToInt32(temparr[2])).ToString())
                {
                    move();
                }
                else
                {
                    fail();
                }
            }
        }

        
    }

    public void Timelimitshow()
    {
        anim.SetBool("timelimitshow", false);
        GameObject.Find("timelimit").SetActive(false);
    }
}
