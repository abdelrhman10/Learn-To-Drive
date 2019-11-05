using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;
using TMPro;

public class riftMan : MonoBehaviour 
{
    public Text speedvalue;
    public TextMeshProUGUI messagestxt;
    public TextMeshProUGUI player_points;
    public player getplayer;
    //public Text messages;
    CarController get_car;
    public GameObject Helping_message;
    public GameObject Controlles_message;
    public GameObject How_points_work;
    public GameObject introtochallenge;

	void Start () 
    {
        get_car = GetComponent<CarController>();
        get_car.m_Topspeed = 0.1f;
        StartCoroutine(play_help_message());
        StartCoroutine(play_challengeintro_message());
        StartCoroutine(play_controlls_message());
        StartCoroutine(Play_howpointswork_message());
	}
	
	void Update ()
    {
        speedvalue.text = get_car.CurrentSpeed.ToString();
        player_points.text = getplayer.points.ToString();
	}
    //2
    public IEnumerator play_help_message()
    {
        
        yield return new WaitForSeconds(2);
        Instantiate(Helping_message, get_car.transform.position,get_car.transform.rotation);
        messagestxt.text = "hello my name is rift and  i am going to teach you how to drive a car";
    }


    //9
    public IEnumerator play_challengeintro_message()
    {

        yield return new WaitForSeconds(10);
        Instantiate(introtochallenge, get_car.transform.position, get_car.transform.rotation);
        messagestxt.text = "first, you are in a challenge, and you should complete it in a good wayif you succeed in the challenge you will be able to explore the whole city but if you fail you have to start from the beginning ";
    }


    //25
    public IEnumerator play_controlls_message()
    {
        
        yield return new WaitForSeconds(26);
        Instantiate(Controlles_message, get_car.transform.position, get_car.transform.rotation);
        messagestxt.text = "Let's take a look on controls, your right controller will be usedto hold the car wheel by holding the right trigger,your left one, left trigger will be used for moving forward,left touch bad for moving backward.";
    }

    //43
    public IEnumerator Play_howpointswork_message()
    {
       
        yield return new WaitForSeconds(45);
        Instantiate(How_points_work, get_car.transform.position, get_car.transform.rotation);
        messagestxt.text = "your success or failure will be based on your points every mistake will decrease your points so you have to be careful";
        get_car.m_Topspeed = 20f;
    }
}
