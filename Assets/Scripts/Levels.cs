using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour {

    public static int LanderLives = 10;
    public int Level = 1;

    public GameObject Level1UI;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Level == 1)
        {
            if (LanderLives == 0)
            {
                Level = 2;
                WaveNum.Wave += 1;
                SceneManager.LoadScene(1);
                Level1UI.SetActive(false);
            }
        }

        if (Level == 2)
        {
            if (LanderLives == 0)
            {
                Level = 3;
                
            }
        }

    }
}
