using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GScroll : MonoBehaviour {

    Material Ground;

    Vector2 Offset;

    public float XVelocity;
    // public float YVelocity;

    private void Awake()
    {
        Ground = GetComponent<Renderer>().material;

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float Xbox = Input.GetAxis("Horizontal");


        // The background will offset to make it look like player is moving right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            XVelocity = 0.7f;
        }

        else if (Xbox >= 0.5)
        {
            XVelocity = 0.7f;
        }

        // The background will offset to make it look like player is moving Left
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            XVelocity = -0.7f;
        }

        else if (Xbox <= -0.7)
        {
            XVelocity = -0.7f;
        }


        // The background is not offset
        else
        {
            XVelocity = 0;
        }


        Offset = new Vector2(XVelocity, 0);

        Ground.mainTextureOffset += Offset * Time.deltaTime;
    }
}
