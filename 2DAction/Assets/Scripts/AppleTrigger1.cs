﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTrigger1 : MonoBehaviour {

    public GameObject apple1;
    public float appleGravity = 1.5f;
    private bool appleFlag = false;

    void Update()
    {
        if (appleFlag)
            apple1.GetComponent<Rigidbody2D>().gravityScale = appleGravity;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
            appleFlag = true;
    }
}
