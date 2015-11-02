using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    [SerializeField]
    private GameObject ball;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(ball.transform.position.x + 12,ball.transform.position.y + 8,ball.transform.position.z + 12);
	}
}
