using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {

    [SerializeField]
    private int scoreMultiplier = 100;

    private GameObject scoreTextfield;
    private TextMesh text;

    private long _score = 0;
    public long Score
    {
        get
        {
            return _score;
        }
    }

	// Use this for initialization
	void Start () {
	    scoreTextfield = GameObject.FindGameObjectWithTag("ScoreTextField");
        text = scoreTextfield.GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void UpdateScore(int score)
    {
        _score += (score * scoreMultiplier);
        text.text = Score.ToString();
    }

}
