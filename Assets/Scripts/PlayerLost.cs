using UnityEngine;
using System.Collections;
using System;

public class PlayerLost : MonoBehaviour {

    [SerializeField]
    private TextMesh es;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider coll)
    {
        if (coll.transform.tag == "Player")
        {
            int tempscore = 0;
            try
            {
                tempscore = int.Parse(es.text);
            }
            catch(Exception e)
            {
                tempscore = 0;
            }
            
            PlayerPrefs.SetInt("score", tempscore);
            Application.LoadLevel("LostScreen");
        }
    }

}
