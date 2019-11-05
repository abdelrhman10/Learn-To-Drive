using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroyHandeler : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("car");

        //objs[0].GetComponent<dontDestroyHandeler>
            for (int i = 0; i < objs.Length; i++)
        {
            if(objs[i].GetComponent<dontDestroyHandeler>()!=null)
            {
                if (objs[i].GetComponent<dontDestroyHandeler>() != this)
                    Destroy(objs[i]);
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
