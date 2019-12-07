using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventaireForge : MonoBehaviour {

    public Canvas P;
    Inventaire Inventaire_Script;
    // Use this for initialization
    void Start () {
        GetComponent<Canvas>().enabled = false;
        Inventaire_Script = GameObject.Find("Inventori").GetComponent<Inventaire>();
    }


    // Update is called once per frame
    void Update () {
		
	}

    public void UpdateImgForge(int slotForge, bool act)
    {
        P.transform.GetChild(0).GetChild(5).GetChild(slotForge).GetComponent<Image>().enabled = !act;
    }


    public void GetSlotinForge()
    {
        for (int i = 0; i < 15; i++)
        {
            if(P.transform.GetChild(0).GetChild(5).GetChild(i).GetComponent<Image>().enabled == true)
            {
                P.transform.GetChild(0).GetChild(5).GetChild(i).GetComponent<Image>().enabled = false;
                bool act = true;
                Inventaire_Script.UpdateImg(i+1, act);

            }
        }
    }
}
