using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buy : MonoBehaviour {
    Inventaire Inventaire_Script;

    InventaireForge InventaireForge_Script;

    public Canvas forge;
    public Canvas inventaire;


    public static bool activationH = true;

    public int slotImgForge;
    int potion = 1;
    static int coin = 500;
    public int slotItem;
    //public Text TeamName;


    void Start()
    {
        Inventaire_Script = GameObject.Find("Inventori").GetComponent<Inventaire>();
        InventaireForge_Script = GameObject.Find("InventoriForge").GetComponent<InventaireForge>();

    }
    void Update()
    {

    }
    // Use this for initialization
    //public void Select () {
    //    Debug.Log(transform.parent.GetSiblingIndex());

	//}
	
	// Update is called once per frame
	public void Test () {
        Debug.Log(coin + "in fonction test");
        if (coin >= 15)
        {
            coin = coin - 15;

            potion++;
            Inventaire_Script.UpdateTxt(slotItem, potion.ToString());
        }


    }
    public void Coin()
    {       
        //float MoneyCoin = int.Parse(TeamName.text);
        if (coin >= 15)
        {
            coin = coin - 15;

            Inventaire_Script.UpdateTxt(12, coin.ToString());
            Debug.Log("achat effectuer" + coin);
        }
        else
        {
            Debug.Log("achat impossible" + coin);
        }
    }


    public void DragAndDrop()
    {
        if (forge.enabled == true)
        {
            activationH = !activationH;
            Inventaire_Script.UpdateImg(slotItem, activationH);
            InventaireForge_Script.UpdateImgForge(slotImgForge, activationH);
            Debug.Log("utilisation slot helmet   " + activationH);
        }


    }
    public void UpdateStuf()
    {
        if (coin >= 50 && !activationH)
        {
            activationH = !activationH;
            coin = coin - 50;
            Inventaire_Script.UpdateTxt(12, coin.ToString());
            InventaireForge_Script.GetSlotinForge();
            Inventaire_Script.UpdateTxt(slotItem, potion.ToString());
        }
    }
}
