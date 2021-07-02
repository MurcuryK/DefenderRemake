using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanderSpawner : MonoBehaviour {

    float LanderNum = 0;
    public Object LanderPrefab;

    public Object EnemyPrefab;


    public int X;
    public int Y;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        X = Random.Range(-50, 50);
        Y = Random.Range(-3, 3);

       if (LanderNum < 10)
        {
            Instantiate(LanderPrefab, new Vector3(X, Y, 0), Quaternion.identity);
            Instantiate(EnemyPrefab, new Vector3(X, Y, 0), Quaternion.identity);


            LanderNum += 1;
        }
	}
}
