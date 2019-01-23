using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLvl : MonoBehaviour {
    [SerializeField] private string SceneLevel;
    [SerializeField] private string SceneLeve2;

    public void sstratlevel1()
    {
        SceneManager.LoadScene(SceneLevel);

    }
    public void sstratlevel2()
    {
        SceneManager.LoadScene(SceneLeve2);

    }

}
