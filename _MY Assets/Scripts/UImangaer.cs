using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class UImangaer : MonoBehaviour {

    public player getplayer;
    public CarController getcar;

    public Text speedtext;
    public Text player_points;

	void Start () 
    {
		
	}
	
	void Update () 
    {
        speedtext.text = getcar.CurrentSpeed.ToString();
        player_points.text ="points :"+ getplayer.points.ToString();
	}
}
