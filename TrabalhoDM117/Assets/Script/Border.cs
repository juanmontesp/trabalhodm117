using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name != "PlayerShip")
        {
            Destroy(col.gameObject);
        }
    }
}
