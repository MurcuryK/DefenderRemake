using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Unitys method which is automatically called when an object leaves the screen

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
