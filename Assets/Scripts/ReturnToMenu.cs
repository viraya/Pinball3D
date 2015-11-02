using UnityEngine;
using System.Collections;

public class ReturnToMenu : MonoBehaviour {

    void Start()
    {

    }

    public void Change()
    {
        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.SetString("username", null);
        Application.LoadLevel("_Menu");
    }

}
