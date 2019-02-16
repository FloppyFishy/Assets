using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class button : MonoBehaviour {

    public Button butt, reset, endless, settings;
    public Button back, man, woman;
    public Slider qt;
    public Animator anim;
    public Text sliderv;
    public Image tickman, tickwoman;
    bool canback;
    bool m; 
    bool w;

    // Use this for initialization
    void Start () {
        butt.onClick.AddListener(startgame);
        reset.onClick.AddListener(resety);
        endless.onClick.AddListener(endlessy);
        back.onClick.AddListener(backy);
        settings.onClick.AddListener(set);
        man.onClick.AddListener(many);
        woman.onClick.AddListener(womany);
        qt.onValueChanged.AddListener(delegate { chnit(); });

        m = false;
        w = false;
        if (PlayerPrefs.GetInt("character") == 0)
        {
            tickman.gameObject.SetActive(true);
            tickwoman.gameObject.SetActive(false);
        } else if (PlayerPrefs.GetInt("character") == 1)
        {
            tickman.gameObject.SetActive(false);
            tickwoman.gameObject.SetActive(true);
        }
        else
        {
            PlayerPrefs.SetInt("character", 0);
            tickman.gameObject.SetActive(true);
            tickwoman.gameObject.SetActive(false);
        }
        canback = false;

        if (PlayerPrefs.GetString("qt") == "Add")
        {
            qt.value = 1;
        }
        else if (PlayerPrefs.GetString("qt") == "Times")
        {
            qt.value = 2;
        }
        else if (PlayerPrefs.GetString("qt") == "Divide")
        {
            qt.value = 3;
        }
        else if (PlayerPrefs.GetString("qt") == "Minus")
        {
            qt.value = 4;
        }

        if (qt.value == 0)
        {
            sliderv.text = "All";
            PlayerPrefs.SetString("qt", "All");
        }
        else if (qt.value == 1)
        {
            sliderv.text = "Add";
            PlayerPrefs.SetString("qt", "Add");
        }
        else if (qt.value == 2)
        {
            sliderv.text = "Times";
            PlayerPrefs.SetString("qt", "Times");
        }
        else if (qt.value == 3)
        {
            sliderv.text = "Divide";
            PlayerPrefs.SetString("qt", "Divide");
        }
        else if (qt.value == 4)
        {
            sliderv.text = "Minus";
            PlayerPrefs.SetString("qt", "Minus");
        }
    }
	
	// Update is called once per frame
	void Update () {
        GameObject.Find("best").GetComponent<Text>().text = "Best: " + PlayerPrefs.GetInt("best").ToString();
        GameObject.Find("best (1)").GetComponent<Text>().text = "Best: " + PlayerPrefs.GetInt("best2").ToString();

        if (Input.GetKey(KeyCode.Escape) && canback == true)
        {
            backy();
        }

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

    void backy()
    {
        canback = false;
        anim.enabled = true;
        settings.gameObject.SetActive(true);
    }

    void set()
    {
        back.gameObject.SetActive(true);
        anim.SetTrigger("show menu");
    }

    void chnit()
    {
        if (qt.value == 0)
        {
            sliderv.text = "All";
            PlayerPrefs.SetString("qt", "All");
        }
        else if (qt.value == 1)
        {
            sliderv.text = "Add";
            PlayerPrefs.SetString("qt", "Add");
        }
        else if (qt.value == 2)
        {
            sliderv.text = "Times";
            PlayerPrefs.SetString("qt", "Times");
        }
        else if (qt.value == 3)
        {
            sliderv.text = "Divide";
            PlayerPrefs.SetString("qt", "Divide");
        }
        else if (qt.value == 4)
        {
            sliderv.text = "Minus";
            PlayerPrefs.SetString("qt", "Minus");
        }
    }

    public void animstop()
    {
        canback = true;
        settings.gameObject.SetActive(false);
        anim.enabled = false;
    }

    void backhide()
    {
        back.gameObject.SetActive(false);
    }

    void many()
    {
        if (m == false)
        {
            tickman.gameObject.SetActive(true);
            tickwoman.gameObject.SetActive(false);
            PlayerPrefs.SetInt("character", 0);
            m = true;
            w = false;
        }
    }

    void womany()
    {
        if (w == false)
        {
            tickman.gameObject.SetActive(false);
            tickwoman.gameObject.SetActive(true);
            PlayerPrefs.SetInt("character", 1);
            w = true;
            m = false;
        }
    }
}
