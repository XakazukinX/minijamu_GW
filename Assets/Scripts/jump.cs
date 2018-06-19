using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

    public float speed = 1;
    public float power = 1;
    public float downpower = 1;
    private Rigidbody rb;

    public GameObject player;

	// Use this for initialization
	void Start () {


        rb = this.GetComponent<Rigidbody>();

		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += transform.up * speed * (power+2.2f) * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.up * speed * downpower * 2;
        }
        else
        {
            transform.position -= transform.up * speed * downpower;
        }




        if(transform.position.y>7.8)
        {
            transform.position = new Vector3(-5.0f,7.8f,0);
        }

	}
}
