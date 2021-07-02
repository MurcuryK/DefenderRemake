using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public Rigidbody2D LazerPrefab; // Where the lazer prefab will be placed
   // float LazerSpeed = 0.05f; // How fast the lazer travels
    

    bool Other = true;

    public static int SBomb = 3;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float Xbox = Input.GetAxis("Horizontal");


        // Determines the direction the ship is moving via keyboard
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Other = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Other = false;
        }

        // Determines the direction the ship is moving via Controller
        //Right
        if (Xbox >= 0.5)
        {
            Other = true;
        }
        //Left
        if (Xbox <= -0.5)
        {
            Other = false;
        }


        // If have previously fired and are not in the cooldown period call the fire method
        if (Input.GetKeyDown(KeyCode.A))
        {
            FireLazer();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            FireLazer();
        }
        
    }

    void FireLazer()
    {
        // Change direction of lazer
        if(Other == true)
        {
            // Create a new instance of the lazer
            Rigidbody2D LPrefab = Instantiate(LazerPrefab, new Vector2(transform.position.x, transform.position.y), gameObject.transform.rotation) as Rigidbody2D;
            // Set the direction of the lazer and how much force to apply
            LPrefab.GetComponent<Rigidbody2D>().AddForce(transform.right * 500);
        }

        if(Other == false)
        {
            // Create a new instance of the lazer
            Rigidbody2D LPrefab = Instantiate(LazerPrefab, new Vector2(transform.position.x, transform.position.y), gameObject.transform.rotation) as Rigidbody2D;
            // Set the direction of the lazer and how much force to apply
            LPrefab.GetComponent<Rigidbody2D>().AddForce(-transform.right * 500);
        }
        
    }

}
