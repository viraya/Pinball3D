using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
	}

    void Update()
    {
       if(Input.GetKey(KeyCode.Space))
       {
           rb.velocity = new Vector3(-300,0,0);
       }
    }
}
