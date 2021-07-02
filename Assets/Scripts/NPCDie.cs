using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDie : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "Lazer")
        {

            Destroy(coll.gameObject);
            Destroy(gameObject);
            PlayerScore.Score -= 250;
             
        }


    }
}
