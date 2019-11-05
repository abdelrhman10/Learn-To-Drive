using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class theend : MonoBehaviour 
{
    public TextMeshProUGUI end_messagestxt;
    //public Text text;
    private player getplayer;
    public int fail_point;
    public GameObject barriers;
    public GameObject WinMessage;
    public GameObject LoseMessage;

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
            
                getplayer = other.gameObject.GetComponent<player>();

                if (getplayer.points > fail_point)
                {
                    Instantiate(WinMessage, transform.position, transform.rotation);
                    end_messagestxt.text = "congratulations now you can explore the whole city";
                    StartCoroutine(win());
                    
                }
                else
                {
                    Instantiate(LoseMessage, transform.position, transform.rotation);
                    end_messagestxt.text = "i am sorry you failled, but i will give you another chance";
                    StartCoroutine(loseSituation());
                }
        }
    }

    public IEnumerator loseSituation()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene("learn to drive");
    }
    public IEnumerator win()
    {
        yield return new WaitForSeconds(2);
        Destroy(barriers);
        Destroy(gameObject);
    }
}
