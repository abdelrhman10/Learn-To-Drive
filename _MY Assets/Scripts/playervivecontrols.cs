using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class playervivecontrols : MonoBehaviour {

    float lastWheelX, lastHandX;

    public CircularDrive OutputDataFromSteeringWHeel;

    public CarController carcontrol;

    public float speed = 1f;

    float acc = 0;
    float Break = 0;
    public bool enableforward;
    public bool enablebackward;
    public bool moveback = false;

    public SteamVR_Action_Boolean moveForward = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("default", "GrabPinch");
    public SteamVR_Action_Boolean movebackward = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("default", "GrabPinch");
    public SteamVR_Action_Boolean direction = SteamVR_Input.GetAction<SteamVR_Action_Boolean>("default", "Teleport");
    public SteamVR_Action_Single single;
    public SteamVR_Input_Sources inputSrcs;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //OutputDataFromSteeringWHeel.CustomBadSign = -1;



        float steeringwheel = OutputDataFromSteeringWHeel.outAngle * Time.deltaTime * 0.1f;


        //if (direction[SteamVR_Input_Sources.LeftHand].stateDown)
        //{
        //    moveback = !moveback;
        //}



        

        if (moveForward[SteamVR_Input_Sources.LeftHand].state)
        {
            acc = 1 * speed;
            Break = 0;
        }
        if (direction[SteamVR_Input_Sources.LeftHand].state)
        {
            Break = -1f * speed;
            acc = 0;
        }
        carcontrol.Move(steeringwheel, single.GetAxis(inputSrcs), Break, Break);
        acc = 0;
        Break = 0;

    }
}
