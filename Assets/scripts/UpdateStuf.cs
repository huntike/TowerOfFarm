using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class UpdateStuf : MonoBehaviour {

    Inventaire Inventaire_Script;
    InventaireForge InventaireForge_Script;

    public Canvas forge;
    public Canvas inventaire;


    public static bool activationH = true;
    public int slotImg;
    public int slotImgForge;
    
    // Use this for initialization
    void Start () {
        Inventaire_Script = GameObject.Find("Inventori").GetComponent<Inventaire>();
        InventaireForge_Script = GameObject.Find("InventoriForge").GetComponent<InventaireForge>();

    }

    // Update is called once per frame
    void Update () {
		
	}


    public void helmet()
    {
        if (forge.enabled == true)
        {    
            activationH = !activationH;
            Inventaire_Script.UpdateImg(slotImg, activationH);
            InventaireForge_Script.UpdateImgForge(slotImgForge, activationH);
            Debug.Log("utilisation slot helmet   " + activationH);

        }


    }
    public void Amelioration()
    {
        activationH = !activationH;
        Debug.Log("utilisation fonction step 1  " + activationH);

        InventaireForge_Script.GetSlotinForge();



    }
}
