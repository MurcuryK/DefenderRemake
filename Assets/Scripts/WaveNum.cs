using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaveNum : MonoBehaviour {

    public static int Wave = 1;
    Text WaveText;

    // Use this for initialization
    void Start () {
        WaveText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        WaveText.text = "Wave: " + Wave;
    }
}
