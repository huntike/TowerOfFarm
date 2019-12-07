using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayHome : MonoBehaviour {

    public Canvas inventaire;
    public Canvas coffre;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("le trigger fonctionne");
            inventaire.enabled = true;
            coffre.enabled = true;


        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("sorti du trigger");
            inventaire.enabled = false;
            coffre.enabled = false;


        }

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
