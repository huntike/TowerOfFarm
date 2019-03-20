using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;



public class Inventaire : MonoBehaviour {

    bool activation = false;
    public GameObject Player;
    public Canvas P;

	// Use this for initialization
	void Start () {
        GetComponent<Canvas>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.I))
        {
            activation = !activation;
            if (!activation)
            {
                Player.GetComponent<charController>().enabled = true;
            }
            else
            {
                Player.GetComponent<charController>().enabled = false;

            }
            GetComponent<Canvas>().enabled = activation;
        }
        
		
	}
    public void UpdateTxt(int slot , string txt)
    {
        P.transform.GetChild(0).GetChild(slot).GetChild(1).GetComponent<Text>().text = txt;
    }
}
