using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mukade_cre : MonoBehaviour {

    public GameObject mukade;
    private float y =1;
    private float nextWave = 1.0f;
    private float pluswave = 2.5f;

    Vector3 callPos;
    private float seconds;
    // Use this for initialization
    void Start()
    {
        seconds = 0f;
    }

    // Update is called once per frame
    void Update()
    {

        seconds += Time.deltaTime;
        if ((seconds > nextWave))
        {

            callMukade();
            nextWave += 2.5f;

        }

    }


    void callMukade()
    {
        y = Random.Range(-7.15f, 7.2f);

        callPos = new Vector3(30, y, 0);
        Instantiate(mukade, callPos, Quaternion.identity);

    }


}
