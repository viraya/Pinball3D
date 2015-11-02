using UnityEngine;
using System.Collections;

public class FlipperForce : MonoBehaviour {

    [SerializeField]
    private GameObject[] flippers;
    [SerializeField]
    private int force;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void FlipperAddForce(bool left, bool right, bool down)
    {
        if (left && down)
        {
            flippers[0].GetComponent<Rigidbody>().AddForce(-force, 0, 0);
        }
        if (right && down)
        {
            flippers[1].GetComponent<Rigidbody>().AddForce(-force, 0, 0);
        }
        if (left && !down)
        {
            flippers[0].GetComponent<Rigidbody>().AddForce(force, 0, 0);
        }
        if (right && !down)
        {
            flippers[1].GetComponent<Rigidbody>().AddForce(force, 0, 0);
        }
    }
}
