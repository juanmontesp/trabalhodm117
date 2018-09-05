using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

    public GameObject ship;
    [SerializeField]
    public float interval = 2;

	// Use this for initialization
	void Start () {

        InvokeRepeating("NextShip", interval, interval);
		
	}
	
	// Update is called once per frame
	void NextShip() {
        Instantiate(ship, transform.position, Quaternion.identity);
		
	}
}
