using UnityEngine;
using System.Collections;

public class PlayerBlockade : MonoBehaviour {

    [SerializeField]
    private GameObject blockade;

    [SerializeField]
    private GameObject ball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider coll)
    {
        if(coll.transform.tag == "Player")
        {
            //if(GameObject.FindGameObjectsWithTag("Blockade") == null)
            //{
            
            //}

            GameObject newWall = Instantiate(blockade, new Vector3(163.3F, -76.4F, 152F), Quaternion.Euler(new Vector3(0, 90, 0))) as GameObject;  // instatiate the object
            newWall.transform.localScale = new Vector3(0.3F, 0.4F, 0.4F); // change its local scale in x y z format
 
        }
    }

}
