﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buy : MonoBehaviour {
    Inventaire Inventaire_Script;
    int i = 1;
    int coin = 251;
    public int slot;
    public Text TeamName;


    void Start()
    {
        Inventaire_Script = GameObject.Find("Inventori").GetComponent<Inventaire>();
    }
    void Update()
    {

    }
    // Use this for initialization
    public void Select () {
        Debug.Log(transform.parent.GetSiblingIndex());

	}
	
	// Update is called once per frame
	public void Test () {
        Debug.Log(coin + "in fonction test");
        if (coin >= 15)
        {
            coin = coin - 15;

            i++;
            Inventaire_Script.UpdateTxt(slot, i.ToString());
        }


    }
    public void Coin()
    {
        
        //float MoneyCoin = int.Parse(TeamName.text);


        if (coin >= 15)
        {
            coin = coin - 15;

            Inventaire_Script.UpdateTxt(slot, coin.ToString());
            Debug.Log("achat effectuer" + coin);
            



        }
        else
        {
            Debug.Log("achat impossible" + coin);
        }
    }
}
