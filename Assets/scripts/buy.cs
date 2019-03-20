using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buy : MonoBehaviour {
    Inventaire Inventaire_Script;
    int i = 1;
    int coin = 251;
    public int slot;
    public GameObject TeamName;


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
        i++;
        Inventaire_Script.UpdateTxt(slot, i.ToString());
		
	}
    public void Coin()
    {
        var MoneyCoin = TeamName.GetComponent<Text>();
        MoneyCoin.text = MoneyCoin.ToString();
        
        int.TryParse(MoneyCoin.text, out coin);

        if (coin >= 15)
        {
            coin = coin - 15;

            Inventaire_Script.UpdateTxt(slot, coin.ToString());

        }
        else
        {
            Debug.Log("achat impossible" + coin);
        }
    }
}
