using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour {

    Material Space;

    Vector2 Offset;

    public float XVelocity;
   // public float YVelocity;

    private void Awake()
    {
        Space = GetComponent<Renderer>().material;

    }



    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        float Xbox = Input.GetAxis("Horizontal");



        // The background will offset to make it look like player is moving right
        if(Input.GetKey(KeyCode.RightArrow))
        {
            XVelocity = 0.3f;
        }

        else if(Xbox >= 0.5)
        {
            XVelocity = 0.3f;
        }

        // The background will offset to make it look like player is moving Left
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            XVelocity = -0.3f;
        }

        else if (Xbox <= -0.5)
        {
            XVelocity = -0.3f;
        }


        // The background is not offset
        else
        {
            XVelocity = 0;
        }


        Offset = new Vector2(XVelocity, 0);

        Space.mainTextureOffset += Offset * Time.deltaTime;
	}
}
