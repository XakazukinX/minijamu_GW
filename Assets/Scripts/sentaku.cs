using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sentaku : MonoBehaviour {

    public GameObject iincho;
	// Use this for initialization
	void Start () {
        iincho = GameObject.Find("iincho");
	}
	
	// Update is called once per frame
	void Update () {


		
	}


	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.tag == "iincho")
        {
            iincho.transform.position = new Vector3(200, 200,0);
          
        }
	}

}
