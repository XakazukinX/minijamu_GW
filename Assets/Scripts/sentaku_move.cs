using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sentaku_move : MonoBehaviour
{

    private float speed;
    public Text wash;
    GameObject System;


    // Use this for initialization
    void Start()
    {
        System = GameObject.Find("System");
        speed = System.GetComponent<System_Script>().sentakukispeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.right * speed;

    }

	private void OnBecameInvisible()
	{

        if (this.gameObject != null)
        {

            System.GetComponent<System_Script>().howmanySentakuki += 1;
            //if(System.GetComponent<System_Script>().sentakukispeed<2)
            if(System.GetComponent<System_Script>().sentakukispeed < 2)
                System.GetComponent<System_Script>().sentakukispeed += 0.002f;
            Destroy(this.gameObject);
        }
        
	}

}
