using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DisplayForge : MonoBehaviour{

    public Canvas inventaire;
    public Canvas forge;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("le trigger fonctionne");
            inventaire.enabled = true;
            forge.enabled = true;


        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("sorti du trigger");
            inventaire.enabled = false;
            forge.enabled = false;


        }

    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
