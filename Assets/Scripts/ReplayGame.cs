using UnityEngine;
using System.Collections;

public class ReplayGame : MonoBehaviour {

    void Start()
    {

    }

    public void Change()
    {
        PlayerPrefs.SetInt("score", 0);
        Application.LoadLevel("PlayField");
    }

}
