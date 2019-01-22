using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackCity : MonoBehaviour {

    [SerializeField] private string SceneLevel;
    public void backtocity()
    {
        SceneManager.LoadScene(SceneLevel);

    }
}
