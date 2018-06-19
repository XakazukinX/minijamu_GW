using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class sentakuki_create : MonoBehaviour {


    public GameObject sentakuki1, sentakuki2,sentakuki3;
    private float y1=1, y2=1,y3=1;
    private float nextWave = 1.0f;
    private float pluswave = 2.5f;
    Vector3 callPos;

    private float seconds;

	// Use this for initialization
	void Start () {

        seconds = 0f;
	}
	
	// Update is called once per frame
	void Update () 
    {
       // Debug.Log(Time.deltaTime+" "+(Time.deltaTime*1000)%10 );
		
        seconds += Time.deltaTime;
        if((seconds > nextWave) && nextWave >25.0f)
        {
            callSentakuki_Hard();
            nextWave += 1.0f;
          //  Debug.Log("はじめまして");

        }
        else if ((seconds > nextWave))
        {

            callSentakuki();
            nextWave += pluswave;
        }


	}


    void callSentakuki()
    {
        y1 = Random.Range(1.9f, 7.2f);
        y2 = Random.Range(-7.15f, -0.1f);

        while (Mathf.Abs(y2 - y1) < 7.0f)
        {
            y1 = Random.Range(1.9f, 7.2f);
            y2 = Random.Range(-7.15f, -0.1f);
        }

        callPos = new Vector3(30, y1, 0);
        Instantiate(sentakuki1, callPos, Quaternion.identity);

        callPos = new Vector3(30, y2, 0);
        Instantiate(sentakuki2, callPos, Quaternion.identity);

      //  Debug.Log(y1 + " " + y2);
    }

    void callSentakuki_Hard()
    {
        
        y1 = Random.Range(1.9f, 7.2f);
        y2 = Random.Range(-7.15f, -0.1f);
        y3 = Random.Range(-7.15f, -0.1f);
        while (Mathf.Abs(y2 - y1) < 7.0f)
        {
            y1 = Random.Range(1.9f, 7.2f);
            y2 = Random.Range(-7.15f, -0.1f);
            y3 = Random.Range(-7.15f, 7.2f);
        }

        callPos = new Vector3(30, y1, 0);
        Instantiate(sentakuki1, callPos, Quaternion.identity);

        callPos = new Vector3(30, y2, 0);
        Instantiate(sentakuki2, callPos, Quaternion.identity);


        callPos = new Vector3(30, y3, 0);
        Instantiate(sentakuki3, callPos, Quaternion.identity);
        //  Debug.Log(y1 + " " + y2);
    }
}
