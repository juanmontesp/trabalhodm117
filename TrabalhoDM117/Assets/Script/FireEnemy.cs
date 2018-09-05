using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemy : MonoBehaviour
{
    [SerializeField]
    public float interval = 3;

    public GameObject bulletPrefab;
    public GameObject bulletPosition;


    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Fire", interval, interval);

    }

    void Fire()
    {
    
        Instantiate(bulletPrefab, bulletPosition.transform.position, Quaternion.identity);
    }


}