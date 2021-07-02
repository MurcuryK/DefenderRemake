using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartBomb : MonoBehaviour {

    public int SmartB;

    GameObject[] ObjectLander;
    GameObject[] ObjectBomber;
    GameObject[] ObjectBaiter;

    public Object ParticleSystem;

    public GameObject Bomb3;
    public GameObject Bomb2;
    public GameObject Bomb1;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        SmartB = Shooting.SBomb;

        // Shooting SmartBombs
        if (Input.GetKeyDown(KeyCode.S))
        {
            if(SmartB > 0)
            {
                DestroyEnemy();
            }
        }

        if (Input.GetButtonDown("Fire2"))
        {
            if (SmartB > 0)
            {
                DestroyEnemy();
            }
        }

        // Removing SmartBombs from UI
        if (SmartB <= 2)
        {
            Destroy(Bomb1);
        }

        if (SmartB <= 1)
        {
            Destroy(Bomb2);
        }

        if (SmartB <= 0)
        {
            Destroy(Bomb3);
        }

    }


    void DestroyEnemy()
    {

        Shooting.SBomb -= 1;

        // Destroy the Landers
        ObjectLander = GameObject.FindGameObjectsWithTag ("Lander");
        
        for(var i=0; i < ObjectLander.Length; i++)
        {
          
            Destroy(ObjectLander[i]);
            PlayerScore.Score += 150;
            Levels.LanderLives = 0;

            Instantiate(ParticleSystem, gameObject.transform.position, Quaternion.identity);

        }


        // Destroy the Bombers
        ObjectBomber = GameObject.FindGameObjectsWithTag("Bomber");

        for (var i = 0; i < ObjectBomber.Length; i++)
        {

            Destroy(ObjectBomber[i]);
            PlayerScore.Score += 250;

            Instantiate(ParticleSystem, gameObject.transform.position, Quaternion.identity);

        }


        // Destroy the Baiter
        ObjectBaiter = GameObject.FindGameObjectsWithTag("Baiter");

        for (var i = 0; i < ObjectBaiter.Length; i++)
        {

            Destroy(ObjectBaiter[i]);
            PlayerScore.Score += 200;

            Instantiate(ParticleSystem, gameObject.transform.position, Quaternion.identity);

        }
    }

}
