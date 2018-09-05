using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    [SerializeField]
    public float speed = 5;

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 dir = new Vector2(h, v);
        GetComponent<Rigidbody2D>().velocity   = dir.normalized * speed;
    }

    void Update()
    {
        //Se o jogo esta pausado, não fazer nada
        if (MenuPause.pausado)
            return;
    }
}
