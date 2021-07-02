using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {

    public static int PlayerLive = 4;
    public static int Score = 0;

    Text ScoreText;

    // Use this for initialization
    void Start () {
        ScoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        ScoreText.text = "" + Score;
	}
   
}
