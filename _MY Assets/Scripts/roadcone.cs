using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadcone : MonoBehaviour 
{
    public player getplayer;
    public AudioSource conecrashsound;
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
            getplayer.points -= 1;
            conecrashsound.Play();
            Destroy(gameObject);
        }
    }
}
