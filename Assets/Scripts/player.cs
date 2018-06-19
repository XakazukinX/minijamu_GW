using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {

    private float Timer;
    public float Interval = 1.0f;
    public bool invisibleFlag;
    private float invisibleTimer;
    public AudioSource sound01;

    public int life=3;
    public Text LIFE;


    public AudioSource sound02;

	// Use this for initialization
	void Start () {
        Timer = Time.time;
        AudioSource[] audioSources = GetComponents<AudioSource>();
        sound01 = audioSources[0];
        sound02 = audioSources[1];  

	}
	
	// Update is called once per frame
	void Update () {
        
        if (invisibleFlag)
        {
            Timer += Time.deltaTime;
            if (Timer > Interval)
            {
                
                gameObject.GetComponent<Renderer>().enabled = !gameObject.GetComponent<Renderer>().enabled;
                //Timer = 0;
            }

            invisibleTimer += Time.deltaTime;
            if (invisibleTimer > Interval)
            {
                
                invisibleTimer = 0;
                invisibleFlag = false;

                gameObject.GetComponent<Renderer>().enabled = true;
            }
        }

        if(transform.position.y<-7.5f)
        {
            invisibleFlag = true;
            sound01.PlayOneShot(sound01.clip);
            life = -1;
            LIFE.GetComponent<Text>().text = "残機：" + life.ToString();
        }
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if(collision.gameObject.tag == "wash" && invisibleFlag == false)
        {
            invisibleFlag = true;
            sound01.PlayOneShot(sound01.clip);
            life -= 1;
            LIFE.GetComponent<Text>().text = "残機："+life.ToString();
        }

        if (collision.gameObject.tag == "mukade")
        {
            
            sound02.PlayOneShot(sound02.clip);
   

        }


	}


}
