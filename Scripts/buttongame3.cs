﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttongame3 : MonoBehaviour
{

    public Button butt1, butt2, butt3, butt4;
    public Button reset;
    public Button next;
    public Button menu;
    GameObject stairy;
    public AudioSource aud;
    public GameObject manArmature;
    public GameObject manFloppy;
    public GameObject camera;
    public AudioClip win;
    public AudioClip lose;
    public AudioClip donit;
    public Animator anim;
    public GameObject confetti;
    public GameObject conf1;
    public Text score;
    public Text time;
    public GameObject failreason;
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
    bool fin;
    bool fial;
    bool poopoo;
    bool itdone;
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
        anim.SetBool("winanim", false);
        PlayerPrefs.SetInt("score", 20);
        fin = false;
        anim.SetBool("timelimitshow", true);
        timer = 0;
        failreason.SetActive(false);
        fial = false;
        StartCoroutine(timey(1F));
        next.gameObject.SetActive(false);
        aud = GameObject.Find("man").GetComponent<AudioSource>();
        conf1.SetActive(false);
        confetti.SetActive(false);
        failed = false;
        camPos = camera.transform.position;
        manFloppy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        done = false;
        butt1.onClick.AddListener(isgood1);
        butt2.onClick.AddListener(isgood2);
        butt3.onClick.AddListener(isgood3);
        butt4.onClick.AddListener(isgood4);
        reset.onClick.AddListener(resety);
        next.onClick.AddListener(nexty);
        menu.onClick.AddListener(menuy);
        PlayerPrefs.SetInt("level", 3);
        stairy = GameObject.Find("stair");
    }

    // Update is called once per frame
    void Update()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
        time.text = timer.ToString();
        if (PlayerPrefs.GetInt("level") == 3)
        {
            if (PlayerPrefs.GetInt("score") == 20)
            {
                stairy = GameObject.Find("stair");
            }
            else if (PlayerPrefs.GetInt("score") == 21)
            {
                stairy = GameObject.Find("stair1");
                if (yeah == false)
                {
                    changeButton();
                }
                yeah = true;
            }
            else if (PlayerPrefs.GetInt("score") == 22)
            {
                stairy = GameObject.Find("stair2");
                if (yeah2 == false)
                {
                    changeButton();
                }
                yeah2 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 23)
            {
                stairy = GameObject.Find("stair3");
                if (yeah3 == false)
                {
                    changeButton();
                }
                yeah3 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 24)
            {
                stairy = GameObject.Find("stair4");
                if (yeah4 == false)
                {
                    changeButton();
                }
                yeah4 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 25)
            {
                stairy = GameObject.Find("stair5");
                if (yeah5 == false)
                {
                    changeButton();
                }
                yeah5 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 26)
            {
                stairy = GameObject.Find("stair6");
                if (yeah6 == false)
                {
                    changeButton();
                }
                yeah6 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 27)
            {
                stairy = GameObject.Find("stair7");
                if (yeah7 == false)
                {
                    changeButton();
                }
                yeah7 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 28)
            {
                stairy = GameObject.Find("stair8");
                if (yeah8 == false)
                {
                    changeButton();
                }
                yeah8 = true;
            }
            else if (PlayerPrefs.GetInt("score") == 29)
            {
                stairy = GameObject.Find("stair9");
                if (yeah9 == false)
                {
                    changeButton();
                }
                yeah9 = true;
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

        if (failed == true && camera.transform.position != camPos)
        {
            camera.transform.position = Vector3.Lerp(camera.transform.position, camPos, Time.deltaTime * 1F);
        }

        if (poopoo == true)
        {
            StopAllCoroutines();
            poopoo = false;
        }

        if (timer == 10F && fial == false)
        {
            failreason.SetActive(true);
            fail();
            StopAllCoroutines();
            fial = true;
        }
    }

    private IEnumerator timey(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            timer++;
        }
    }

    private IEnumerator poo(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            manArmature.SetActive(false);
            manFloppy.SetActive(true);
            manFloppy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            manFloppy.GetComponent<Rigidbody2D>().AddForce((transform.right + new Vector3(0, -5, 0)) * -1000F);
            poopoo = true;
        }
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
        menu.gameObject.SetActive(false);
        next.gameObject.SetActive(true);
        aud.clip = win;
        aud.Play();
        itdone = true;
        StartCoroutine(poo(2F));
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
        SceneManager.LoadScene("menu");
        if (PlayerPrefs.GetInt("best") < PlayerPrefs.GetInt("score"))
        {
            PlayerPrefs.SetInt("best", PlayerPrefs.GetInt("score"));
        }
    }

    void changeButton()
    {
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
        timer = 0;
        aud.clip = donit;
        aud.Play();
        if (bum == true)
        {
            anim.SetTrigger("buttonpress");
            bum = false;
        }
        if (done == false)
        {
            GameObject.Find("GameObject").GetComponent<manimateanimator>().moving();
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 1);
        }
        done = true;
        confetti.SetActive(true);
    }

    void resety()
    {
        SceneManager.LoadScene("game3");
    }

    void fail()
    {
        if (cheat == false)
        {
            if (PlayerPrefs.GetInt("best") < PlayerPrefs.GetInt("score"))
            {
                PlayerPrefs.SetInt("best", PlayerPrefs.GetInt("score"));
            }
            aud.clip = lose;
            aud.Play();
            failed = true;
            manArmature.SetActive(false);
            manFloppy.SetActive(true);
            manFloppy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            manFloppy.GetComponent<Rigidbody2D>().AddForce(transform.right * 800F);
            Debug.Log("failed");
            anim.SetBool("failanim", true);
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

    void timelimitshow()
    {
        anim.SetBool("timelimitshow", false);
        GameObject.Find("timelimit").SetActive(false);
    }
}