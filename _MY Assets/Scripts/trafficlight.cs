using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficlight : MonoBehaviour {

    public player getplayer;
    public GameObject greenlight;
    public GameObject redlight;
    public bool isred;
    public bool isgreen;
    public float trafficlighttime=5f;
    
	void Start ()
    {
        redlight.SetActive(true);
        greenlight.SetActive(false);
        isred = true;
        isgreen = false;
	}
	
	void Update () 
    {
        StartCoroutine(changestate());
	}
    
    IEnumerator changestate()
    {
        if (isred)
        {
            yield return new WaitForSeconds(trafficlighttime);
            redlight.SetActive(false);
            greenlight.SetActive(true);
            isred = false ;
            isgreen = true ;
        }
        else if (isgreen)
        {
            yield return new WaitForSeconds(trafficlighttime);
            redlight.SetActive(true);
            greenlight.SetActive(false);
            isred = true;
            isgreen = false;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "car" && isred)
        {
            Debug.Log("in");
            getplayer.points -= 1;
        }
    }

    
    
}
