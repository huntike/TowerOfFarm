using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffichePanelCombat : MonoBehaviour {
	
	public GameObject armepanel;
	public GameObject sortpanel;
	public GameObject potionpanel;
	public GameObject fuirpanel;
	public GameObject infopanel;
	
	// Use this for initialization
	void Start () {
		armepanel.SetActive(false);

		sortpanel.SetActive(false);

		potionpanel.SetActive(false);

		fuirpanel.SetActive(false);

		infopanel.SetActive(false);
	}
}