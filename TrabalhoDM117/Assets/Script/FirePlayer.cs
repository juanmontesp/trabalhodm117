using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayer : MonoBehaviour
{

    public GameObject bullet;
    public GameObject leftBullet;
    public GameObject rightBullet;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Instantiate(bullet, leftBullet.transform.position, Quaternion.identity);
            Instantiate(bullet, rightBullet.transform.position, Quaternion.identity);
     
        }
    }
 
}