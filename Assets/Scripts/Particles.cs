using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour {

    private float StartTime, Duration = 1.0f;

    // Use this for initialization
    void Start()
    {

        StartTime = Time.time;

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time - StartTime > Duration)
        {
            Destroy(this.gameObject);
        }

    }
}
