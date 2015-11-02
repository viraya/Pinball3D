using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UploadScore : MonoBehaviour {
	private int score;
	private string uname;
    [SerializeField]
    private Text sl;

	// Use this for initialization
	void Start()
	{
		score = PlayerPrefs.GetInt("score");
		uname = PlayerPrefs.GetString("username");
		string url = "http://re-creator.com/pinball/highscore.php";
		
		WWWForm form = new WWWForm();
		
		form.AddField("username", uname);
		form.AddField("score", score);
		
		WWW www = new WWW(url, form);
		
		StartCoroutine(WaitForRequest(www));
		
	}
	
	IEnumerator WaitForRequest(WWW www)
	{
		
		yield return www;
		
		if (www.error != null)
		{
			Debug.Log("Failed : " + www.error);
		}
		else
		{
			Debug.Log("The score script was successfully executed.");
            sl.text = www.text;
            Debug.Log(www.text);
		}
	}
}
