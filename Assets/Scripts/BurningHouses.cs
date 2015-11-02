using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BurningHouses : MonoBehaviour {

    private GameObject[] BurnableHouses;
    private List<bool> BurnTriggers;
    [SerializeField]
    private GameObject Fire;
    ScoreScript ss;

    void Awake()
    {
        ss = GameObject.FindObjectOfType<ScoreScript>();
    }

	// Use this for initialization
	void Start () {

        BurnableHouses = GameObject.FindGameObjectsWithTag("BurningHouse");
        BurnTriggers = new List<bool>();
        
        foreach(GameObject temp in BurnableHouses)
        {
            BurnTriggers.Add(false);
        }
        
        //Debug.Log(BurnableHouses.Length);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void BurnDown()
    {
        string FireName = "";
        int ran = Random.Range(0,BurnableHouses.Length);
        if(!BurnTriggers[ran])
        {
            Fire.name = ran.ToString();
            Instantiate(Fire, BurnableHouses[ran].transform.position, Quaternion.Euler(-90, 0, 0));
            BurnTriggers[ran] = true;
        }
        else
        {
            FireName += ran.ToString();
            FireName += "(Clone)";
            Destroy(GameObject.Find(FireName));
            BurnTriggers[ran] = false;
        }
        int multiplied = 0;
        foreach(bool Smulti in BurnTriggers)
        {
            if(Smulti)
            {
                multiplied++;
            }
        }

        ss.UpdateScore(multiplied);

        

    }
}
