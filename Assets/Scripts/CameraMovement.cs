using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    // Call the player
    public GameObject Player;

    public float speed = 2.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        
        // Creates a frame-rate separt to the player following system
        float interpolation = speed * Time.deltaTime;


        // Checks the Cameras position
        Vector3 position = this.transform.position;

        // Sets the axis' to the players with a small delay
        //position.y = Mathf.Lerp(this.transform.position.y, Player.transform.position.y, interpolation);
        position.x = Mathf.Lerp(this.transform.position.x, Player.transform.position.x, interpolation);

        this.transform.position = position;
    }
}
