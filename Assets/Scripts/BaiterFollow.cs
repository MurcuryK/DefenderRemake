using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiterFollow : MonoBehaviour {

    public float Speed;
    private Transform PTarget;

    public Rigidbody2D ELazerPrefab;

    public int num = 0;

    // Use this for initialization
    void Start () {
        PTarget = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        

    }

    // Update is called once per frame
    void Update () {

        // Moving toward player
        if(Vector2.Distance(transform.position, PTarget.position) >3)
        {
            // Moving towards player location
            transform.position = Vector2.MoveTowards(transform.position, PTarget.position, Speed * Time.deltaTime);
        }


        //// Shooting
        //if (Vector2.Distance(transform.position, PTarget.position) <= 3)
        //{
        //    StartCoroutine(EnShoot());

        //    num = 0;
        //}
    }
    //IEnumerator EnShoot()
    //{

    //    yield return new WaitForSecondsRealtime(1);
    //    if (num == 0)
    //    {
    //        // Create a new instance of the lazer
    //        Rigidbody2D ELPrefab = Instantiate(ELazerPrefab, new Vector2(transform.position.x, transform.position.y), gameObject.transform.rotation) as Rigidbody2D;

    //        // Set the direction of the lazer and how much force to apply
    //        ELPrefab.GetComponent<Rigidbody2D>().AddForce(transform.right * 500);
    //        ELPrefab.GetComponent<Rigidbody2D>().AddForce(-transform.right * 500);
    //        num += 1;
    //    }
       
    //}


}
