﻿using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    public Rigidbody2D OurRigidBody;
    public float moveupdown;
    public float moveleftright;


    // Use this for initialization
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        moveleftright = Input.GetAxis("Vertical");
        moveupdown = Input.GetAxis("Horizontal");
        transform.Translate(0.1f * moveupdown, 0.1f * moveleftright, 0);

        if (Input.GetKeyDown("space"))
        {
            OurRigidBody.mass = 1;
        }

        if (Input.GetKeyDown("e"))
        {
            OurRigidBody.mass = 0;
        }
    }

}