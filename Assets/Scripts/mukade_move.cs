using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mukade_move : MonoBehaviour {

    private int howManyMukade = 0;
    public float speed = 0.2f;
    public Text mukade;
    GameObject System;



	// Use this for initialization
	void Start () {
        System = GameObject.Find("System");
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.position -= transform.right * speed;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "iincho")
        {

            System.GetComponent<System_Script>().howmanyMukade +=1;
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {

        Destroy(gameObject);

    }
}
