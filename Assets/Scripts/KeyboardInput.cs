using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour {

    FlipperForce ff;
    BallSpawning bs;

	// Use this for initialization
	void Start () {
        ff = GameObject.FindObjectOfType<FlipperForce>();
        bs = GameObject.FindObjectOfType<BallSpawning>();
	}
	
	// Update is called once per frame
	void Update () {

	    if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            ff.FlipperAddForce(true,false,true);
        }
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            ff.FlipperAddForce(false,true,true);
        }

        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            ff.FlipperAddForce(true, false,false);
        }
        if (Input.GetKeyUp(KeyCode.RightControl))
        {
            ff.FlipperAddForce(false, true,false);
        }

        // spawning of the balls
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bs.SpawnBall();
        }

	}
}
