using System.Collections;
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
        GameObject.Find("Canva").GetComponent<buttongameEndless>().done = false;
        confetti.SetActive(false);
        GameObject.Find("Canva").GetComponent<buttongameEndless>().bum = true;
    }

    public void moving()
    {
        anim.enabled = true;
        anim.SetBool("up", true);
    }
}
