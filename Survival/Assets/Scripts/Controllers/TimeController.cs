using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimeController : MonoBehaviour {

    public float timer = 0;




    public GameObject player1;
    public GameObject deathObject;
    public GameObject deathObject2;
    public GameObject deathObject3;
    public GameObject deathObject4;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        Debug.Log(timer);

 

        if(timer >= 60 && player1 == true)
        {
            Destroy(deathObject);
            
        }

    }



}
