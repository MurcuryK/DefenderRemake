using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperDrive : MonoBehaviour {

    public int X;
    public int Y;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 translation = new Vector3(0, 0, 0);

        X = Random.Range(-50, 50);
        Y = Random.Range(-3, 3);

        if (Input.GetKeyDown(KeyCode.E))
        {
            translation = new Vector2(X, Y);
        }

        if (Input.GetButtonDown("Fire3"))
        {
            translation = new Vector2(X, Y);
        }


        transform.Translate(translation);
    }
}
