﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVScroll : MonoBehaviour {

    [SerializeField]
    public Vector2 speed;

    void LateUpdate()
    {
        GetComponent<Renderer>().material.mainTextureOffset = speed * Time.time;


    }
    void Update()
    {
        if (MenuPause.pausado)
            return;
    }
}

