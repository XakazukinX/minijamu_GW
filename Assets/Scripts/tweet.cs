using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tweet : MonoBehaviour {

    private int twiScore;
	// Use this for initialization
	void Start () 
    {
        twiScore = System_Script.getSentakuki() * System_Script.getMukade();
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    public void onClick()
    {

            naichilab.UnityRoomTweet.Tweet ("refrigerator", "あなたの洗濯機回避力は " + twiScore + " です", "洗濯機よけろ");
            string message = "あなたの洗濯機回避力は " + twiScore + " です　#洗濯機よけろ " + "https://unityroom.com/games/refrigerator";
            Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(message));
    }
}
