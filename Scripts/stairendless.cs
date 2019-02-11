using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stairendless : MonoBehaviour
{

    public GameObject stairy;
    GameObject stairClone;
    float count;
    string texty;
    public Button butt1, butt2, butt3, butt4;
    int ansran;
    int oneitdone;
    public bool dostuff;
    List<string> donesums = new List<string>();
    Vector3 stairpos;


    // Use this for initialization
    void Start()
    {
        stairpos = new Vector3(-1.45F, 1.06F, 0);
        texty = ranQ();
        while (texty == "no")
        {
            texty = ranQ();
        }
        if (texty == "no")
        {
            texty = "7 + 8";
        }
        stairy.GetComponentInChildren<Text>().text = texty;
        count = 1;
        stairClone = Instantiate(stairy, stairy.transform.position + stairpos, stairy.transform.rotation);
        texty = ranQ();
        while (texty == "no")
        {
            texty = ranQ();
        }
        if (texty == "no")
        {
            texty = "7 + 8";
        }
        stairClone.GetComponentInChildren<Text>().text = texty;
        stairClone.name = "stair" + count;
        stairs();

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

        ansran = UnityEngine.Random.Range(0, 5);
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
            while (Convert.ToInt32(butt2.GetComponentInChildren<Text>().text) < 1)
            {
                butt2.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt1.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
            while (Convert.ToInt32(butt3.GetComponentInChildren<Text>().text) < 1)
            {
                butt3.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt1.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
            while (Convert.ToInt32(butt4.GetComponentInChildren<Text>().text) < 1)
            {
                butt4.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt1.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
        }
        else if (oneitdone == 2)
        {
            while (Convert.ToInt32(butt1.GetComponentInChildren<Text>().text) < 1)
            {
                butt1.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt2.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
            while (Convert.ToInt32(butt3.GetComponentInChildren<Text>().text) < 1)
            {
                butt3.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt2.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
            while (Convert.ToInt32(butt4.GetComponentInChildren<Text>().text) < 1)
            {
                butt4.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt2.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
        }
        else if (oneitdone == 3)
        {
            while (Convert.ToInt32(butt1.GetComponentInChildren<Text>().text) < 1)
            {
                butt1.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt3.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
            while (Convert.ToInt32(butt2.GetComponentInChildren<Text>().text) < 1)
            {
                butt2.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt3.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
            while (Convert.ToInt32(butt4.GetComponentInChildren<Text>().text) < 1)
            {
                butt4.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt3.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
        }
        else if (oneitdone == 4)
        {
            while (Convert.ToInt32(butt1.GetComponentInChildren<Text>().text) < 1)
            {
                butt1.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt4.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
            while (Convert.ToInt32(butt2.GetComponentInChildren<Text>().text) < 1)
            {
                butt2.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt4.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
            while (Convert.ToInt32(butt3.GetComponentInChildren<Text>().text) < 1)
            {
                butt3.GetComponentInChildren<Text>().text = (Convert.ToInt32(butt4.GetComponentInChildren<Text>().text) + UnityEngine.Random.Range(-12, 15)).ToString();
            }
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

        if (butt1.GetComponentInChildren<Text>().text != ans.ToString() && butt2.GetComponentInChildren<Text>().text != ans.ToString() && butt3.GetComponentInChildren<Text>().text != ans.ToString() && butt4.GetComponentInChildren<Text>().text != ans.ToString())
        {
            ansran = UnityEngine.Random.Range(1, 5);
            Debug.Log(ansran);
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

    // Update is called once per frame
    void Update()
    {
        if ((PlayerPrefs.GetInt("scoreEL") % 8) == 0 && dostuff == false)
        {
            stairs();
            dostuff = true;
        }
    }

    void stairs()
    {
        for (int i = 0; i < 8; i++)
        {
            count++;
            stairClone = Instantiate(stairy, stairClone.transform.position + stairpos, stairy.transform.rotation);
            texty = ranQ();
            while (texty == "no")
            {
                texty = ranQ();
            }
            if (texty == "no")
            {
                texty = "7 + 8";
            }
            stairClone.GetComponentInChildren<Text>().text = texty;
            stairClone.name = "stair" + count;
        }
    }

    string ranQ()
    {
        string[] operaters = { " + ", " - ", " ÷ ", " x " };
        string output = UnityEngine.Random.Range(1, 13).ToString() + operaters[UnityEngine.Random.Range(0, operaters.Length)] + UnityEngine.Random.Range(1, 13).ToString();
        string[] valid = output.Split(' ');
        if (valid[1] == "÷")
        {
            if (Convert.ToInt32(valid[0]) / Convert.ToInt32(valid[2]) < 0)
            {
                return "no";
            }
            else
            {
                if (Convert.ToInt32(valid[0]) % Convert.ToInt32(valid[2]) == 0)
                {
                    donesums.Add(output);
                    return output;
                }
                else
                {
                    return "no";
                }
            }

        }
        else if (valid[1] == "-")
        {
            if (Convert.ToInt32(valid[0]) - Convert.ToInt32(valid[2]) < 0)
            {
                return "no";
            }
            else
            {
                donesums.Add(output);
                return output;
            }
        }
        else if (valid[1] == "+")
        {
            if (Convert.ToInt32(valid[0]) + Convert.ToInt32(valid[2]) < 0)
            {
                return "no";
            }
            else
            {
                donesums.Add(output);
                return output;
            }
        }
        else if (valid[1] == "x")
        {
            if (Convert.ToInt32(valid[0]) * Convert.ToInt32(valid[2]) < 0)
            {
                return "no";
            }
            else
            {
                donesums.Add(output);
                return output;
            }
        }
        else
        {
            return null;
        }
    }
}