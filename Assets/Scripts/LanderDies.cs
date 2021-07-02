using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanderDies : MonoBehaviour {

    public Object ParticleSystem;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "Lazer")
        {

            Destroy(coll.gameObject);
            Destroy(gameObject);
            PlayerScore.Score += 150;
            Levels.LanderLives -= 1;

            Instantiate(ParticleSystem, gameObject.transform.position, Quaternion.identity);
        }

    }
}
