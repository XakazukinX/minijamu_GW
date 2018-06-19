using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class System_Script : MonoBehaviour {



    //public readonly static System_Script Instance = new System_Script();
    public float sentakukispeed = 0.5f;
    public int howmanySentakuki = 0;
    //public int howmanyClover = 0;
    public int howmanyMukade = 0;

    public static int _howmanySentakuki = 0;
    public static int _howmanyMukade = 0;




    public Text wash;
    public Text mukade;


    public GameObject iincho; 


    public static int getSentakuki()
    {
        return _howmanySentakuki;
    }


    public static int getMukade()
    {
        return _howmanyMukade;
    }

	// Use this for initialization
	void Start () 
    {
        iincho = GameObject.Find("iincho");
	}
	
	// Update is called once per frame
	void Update () {
        
        //Debug.Log(howmanySentakuki/2+" "+sentakukispeed );
        wash.GetComponent<Text>().text = "避けた数："+(howmanySentakuki).ToString();
        mukade.GetComponent<Text>().text = "集めたムカデ："+howmanyMukade.ToString();

        _howmanySentakuki = howmanySentakuki;
        _howmanyMukade = howmanyMukade;


        if (iincho.GetComponent<player>().life < 0)
        {
            Application.LoadLevel("GameOver");
        }

	}



}
