using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Setting the ship animation as a variable
    private Animator Ani;

    // This is the bounding size of the ship which should be half the width and/or height.
    // It has been set as public so the value can be edited in the Unity properties editor rather than changing the code.
    public float BoundingSize = 20.0f;

    // Store refernece to the game camera
    Camera GameCamera;


    public float UICover = 5f;

    // Use this for initialization
    void Start () {

        // Getting the ship animator
        Ani = this.GetComponent<Animator>();
        Ani.speed = 1;

        // Camera
        GameCamera = FindObjectOfType<Camera>();
        gameObject.transform.position = GameCamera.ScreenToWorldPoint(new Vector3(50, GameCamera.pixelHeight / 2));
        transform.Translate(new Vector3(0, 0, 10));


    }
	
	// Update is called once per frame
	void Update () {

        float Xbox = Input.GetAxis("Horizontal");


        // Setting the ship direction change via key presses
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Ani.SetInteger("Action1", 0);
            Ani.speed = 1;
        }
        // Right
        else if (Xbox >= 0.5)
        {
            Ani.SetInteger("Action1", 0);
            Ani.speed = 1;
        }


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Ani.SetInteger("Action1", 1);
            Ani.speed = 1;
        }
        // Left
        // Right
        else if (Xbox <= -0.5)
        {
            Ani.SetInteger("Action1", 1);
            Ani.speed = 1;
        }


        // The ship's translation is how the ship will move
        // Every frame this number will start at 0, 0 and will change based upon input from the player

        Vector3 translation = new Vector3(0, 0, 0);

        // This set of statements gets the keyboard input from the player and sets the translation of the ship to the right direction

        if (Input.GetKey(KeyCode.RightArrow))
        {
            translation = new Vector2(6, 0) * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            translation = new Vector2(-6, 0) * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.UpArrow))
        {
            translation = new Vector2(0, 6) * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            translation = new Vector2(0, -6) * Time.deltaTime;
        }

        float Speed = Input.GetAxis("Horizontal");
        translation += new Vector3(Speed * 3, 0) * Time.deltaTime;

        Speed = Input.GetAxis("Vertical");
        translation += new Vector3(0, Speed * 3) * Time.deltaTime;



        Vector3 NewPostion = GameCamera.WorldToScreenPoint(transform.position + translation);

        // Now check whether the player postion relative to the camera, 
        // if detected the translation will be set to 0,0 meaning the ship will not move past a set point in the camera

        if (NewPostion.y + BoundingSize > GameCamera.pixelHeight + UICover)
        {
            translation = new Vector2(0, 0);
        }
        else if (NewPostion.y - BoundingSize < 0)
        {
            translation = new Vector2(0, 0);
        }

        transform.Translate(translation);
    }

}

