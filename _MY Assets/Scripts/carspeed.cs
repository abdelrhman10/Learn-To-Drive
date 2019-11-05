using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class carspeed : MonoBehaviour {


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        
	}
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("out");
        if (other.gameObject.tag == "car")
        {
            Debug.Log("in");
            
        }
    }
}
