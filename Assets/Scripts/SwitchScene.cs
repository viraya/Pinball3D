using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SwitchScene : MonoBehaviour {

    [SerializeField]
    private Text gt;
    [SerializeField]
    private Text ph;

    private string text;

    void Start() {

    }

	public void Change() {
        text = gt.text;
        if(text != "")
        {
            PlayerPrefs.SetString("username", text);
            Application.LoadLevel("PlayField");
        }
        else
        {
            ph.text = "Please enter username.";
        }
	}
}

