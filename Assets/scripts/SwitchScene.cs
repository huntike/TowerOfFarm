using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

	public string NomScene;

	public void prochaineScene()
	{
		SceneManager.LoadScene(NomScene);
	}

    public string SceneFuir;

    public void fuirCombat()
    {
        SceneManager.LoadScene(SceneFuir);
    }
}
