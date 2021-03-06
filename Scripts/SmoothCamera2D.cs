﻿using UnityEngine;
using System.Collections;

public class SmoothCamera2D : MonoBehaviour
{

    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform woman;
    public Transform mam;
    Transform target;
    public Camera cameras;

    private void Start()
    {
        if (PlayerPrefs.GetInt("character") == 0)
        {
            target = mam;
        }
        else if (PlayerPrefs.GetInt("character") == 1)
        {
            target = woman;
        }
        else
        {
            target = mam;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        if (target && cameras.transform.position.y > 0)
        {
            Vector3 point = cameras.WorldToViewportPoint(target.position);
            Vector3 delta = target.position - cameras.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }

    }
}