using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour {


    public int Lives;
    public int Score;
    public bool Increase1;

    public GameObject Life3;
    public GameObject Life2;
    public GameObject Life1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Lives = PlayerScore.PlayerLive;
        Score = PlayerScore.Score;

        if(Increase1 == false)
        {
            if (Score >= 2000)
            {
                PlayerScore.PlayerLive += 1;
                Increase1 = true;
            }
            
        }
        

        // First life
        if (Lives <= 3)
        {
            Life3.SetActive(false);
        }
        if (Lives == 4)
        {
            Life3.SetActive(true);
        }

        // Second life
        if (Lives <= 2)
        {
            Life2.SetActive(false);
        }
        if (Lives == 3)
        {
            Life2.SetActive(true);
        }

        // Third life
        if (Lives <= 1)
        {
            Life1.SetActive(false);
        }
        if (Lives == 2)
        {
            Life1.SetActive(true);
        }
    }


    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "Lander")
        {
            PlayerScore.PlayerLive -= 1;
        }

        if (coll.gameObject.tag == "Bomber")
        {
            PlayerScore.PlayerLive -= 1;
        }

        if (coll.gameObject.tag == "Baiter")
        {
            PlayerScore.PlayerLive -= 1;
        }





        if (coll.gameObject.tag == "ELazer")
        {

            Destroy(coll.gameObject);
            PlayerScore.PlayerLive -= 1;
        }
    }

}
