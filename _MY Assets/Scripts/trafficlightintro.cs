using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class trafficlightintro : MonoBehaviour 
{
    public riftMan getmessagestxt;
    public CarController get_car;
    public AudioSource trafficlightsound;
    public bool setfullspeed = false;
	void Start () 
    {
        
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (setfullspeed)
        {
            StartCoroutine(set_full_speed());
        }
	}
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "car")
        {
            getmessagestxt.messagestxt.text = "Now you will face a traffic light, red means you should wait, green allows you to move";
            trafficlightsound.Play();
            get_car.m_Topspeed = 5f;
            setfullspeed = true;
        }

        Destroy(gameObject,8f);
    }

    public IEnumerator set_full_speed()
    {
        yield return new WaitForSeconds(7);
        get_car.m_Topspeed = 100f;
    }
}
