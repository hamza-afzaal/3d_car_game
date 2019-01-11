using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        Debug.Log("Hello World!");
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }

    //void fixedUpdate()
    //{
        
    //}
}
