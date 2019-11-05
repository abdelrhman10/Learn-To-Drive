using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class speedlimite : MonoBehaviour {

    public float speed_limit_value;
    player getplayer;
    //public CarController getcar;

	void Start () 
    {
		
	}
	
	void Update () 
    {
		
	}
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "car")
        {
            if (other.gameObject.GetComponent<CarController>().CurrentSpeed > speed_limit_value)
            {
                getplayer = other.gameObject.GetComponent<player>();
                getplayer.points -= 1;
            }
            
        }
    }
}
