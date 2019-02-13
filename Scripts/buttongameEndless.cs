using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttongameEndless : MonoBehaviour {

    public Button butt1, butt2, butt3, butt4;
    public Button reset;
    public Button next;
    public Button menu;
    public GameObject stairy;
    public AudioSource aud;
    public GameObject manArmature;
    public GameObject manFloppy;
    public GameObject cameras;
    public AudioClip win;
    public AudioClip lose;
    public AudioClip donit;
    public Animator anim;
    public GameObject confetti;
    public GameObject conf1;
    public Text score;
    public bool done;
    int ansran;
    int oneitdone;
    int countpoo;
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
    bool poopoo;
    bool itdone;
    public bool bum = true;
    public bool cheat;
    Vector3 camPos;
    Vector3 tempos;

    int temp1;
    int temp2;
    int temp3;
    int temp4;

    // Use this for initialization
    void Start()
    {
        reset.gameObject.SetActive(false);
        menu.gameObject.SetActive(false);
        next.gameObject.SetActive(false);
        countpoo = 0;
        next.gameObject.SetActive(false);
        aud = GameObject.Find("man").GetComponent<AudioSource>();
        conf1.SetActive(false);
        confetti.SetActive(false);
        failed = false;
        manFloppy.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        done = false;
        butt1.onClick.AddListener(isgood1);
        butt2.onClick.AddListener(isgood2);
        butt3.onClick.AddListener(isgood3);
        butt4.onClick.AddListener(isgood4);
        reset.onClick.AddListener(resety);
        menu.onClick.AddListener(menuy);
        PlayerPrefs.SetInt("scoreEL", 0);
        PlayerPrefs.SetInt("level", 0);
        stairy = GameObject.Find("stair");
    }
	
	// Update is called once per frame
	void Update () {
        score.text = PlayerPrefs.GetInt("scoreEL").ToString();

        if (poopoo == true)
        {
            StopAllCoroutines();
            poopoo = false;
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
            manFloppy.GetComponent<Rigidbody2D>().AddForce((transform.right + new Vector3(0,-5,0)) * -1000F);
            poopoo = true;
        }
    }
    private IEnumerator chan(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        changeButton();
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
        countpoo++;
        stairy = GameObject.Find("stair" + countpoo.ToString());
        StartCoroutine(chan(0.2F));
        Debug.Log(stairy.name);
        GameObject.Find("camera").GetComponent<stairendless>().dostuff = false;
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
            PlayerPrefs.SetInt("scoreEL", PlayerPrefs.GetInt("scoreEL") + 1);
        }
        done = true;
        confetti.SetActive(true);
    }

    void resety()
    {
        SceneManager.LoadScene("endless");
    }

    void menuy()
    {
        SceneManager.LoadScene("menu");
        if (PlayerPrefs.GetInt("best2") < PlayerPrefs.GetInt("scoreEL"))
        {
            PlayerPrefs.SetInt("best2", PlayerPrefs.GetInt("scoreEL"));
        }
    }

    void fail()
    {
        if (cheat == false)
        {
            if (PlayerPrefs.GetInt("best2") < PlayerPrefs.GetInt("scoreEL"))
            {
                PlayerPrefs.SetInt("best2", PlayerPrefs.GetInt("scoreEL"));
            }
            cameras.GetComponent<SmoothCamera2D>().enabled = true;
            reset.gameObject.SetActive(true);
            menu.gameObject.SetActive(true);
            aud.clip = lose;
            aud.Play();
            failed = true;
            manArmature.SetActive(false);
            manFloppy.SetActive(true);
            StartCoroutine(fallfail(1.5F));
            Debug.Log("failed");
            anim.SetBool("failanim", true);
        }

    }

    private IEnumerator fallfail(float waitTime)
    {
        while (true)
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
}
