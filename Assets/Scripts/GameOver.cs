using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {


    public Text sentakuki;
    public Text mukade;
    public Text score;
    public int twiScore;

	// Use this for initialization
	void Start () 
    {
        sentakuki.GetComponent<Text>().text = "避けた洗濯機：" + System_Script.getSentakuki().ToString();
        mukade.GetComponent<Text>().text = "集めたムカデ：" + System_Script.getMukade().ToString();
        score.GetComponent<Text>().text = "すこあ：" + (System_Script.getSentakuki() * System_Script.getMukade()).ToString();


	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("minijam_act");
        }


	}
}
