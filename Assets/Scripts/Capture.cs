using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capture : MonoBehaviour {

    public GameObject Land;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "Lander")
        {
            Land = coll.gameObject;

            Land.transform.parent = gameObject.transform;

            transform.gameObject.tag = "Captured";
        }

    }
}
