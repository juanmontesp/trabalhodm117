using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinousVelocity : MonoBehaviour
{

    public Vector2 velocity;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
    }
    void Update()
    {
        if (MenuPause.pausado)
            return;
    }
}
