using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLvl : MonoBehaviour {
    [SerializeField] private string SceneLevel;
    public void sstratthegame()
    {
        SceneManager.LoadScene(SceneLevel);

    }

}
