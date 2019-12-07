using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffichePanelMenuPrincipal : MonoBehaviour {
	
	public GameObject parametrepanel;
	public GameObject comfirmpanel;
	public GameObject comfirmquitpanel;
	
	// Use this for initialization
	void Start () {
		parametrepanel.SetActive(false);

		comfirmpanel.SetActive(false);

		comfirmquitpanel.SetActive(false);
	}
}