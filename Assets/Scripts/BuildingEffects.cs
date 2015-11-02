using UnityEngine;
using System.Collections;

public class BuildingEffects : MonoBehaviour {

    [SerializeField]
    private GameObject ball;
    private Rigidbody rb;
    BurningHouses bh;

    void Awake()
    {
        rb = ball.GetComponent<Rigidbody>();
        bh = GameObject.FindObjectOfType<BurningHouses>();
    }

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnCollisionEnter(Collision coll)
    {
        if(coll.transform.tag == "Bumbers")
        {
            rb.AddForce(new Vector3(-GetDirection(coll.gameObject).x * 2000, (GetDirection(coll.gameObject).y - (GetDirection(coll.gameObject).y * 2)) * 2000, -GetDirection(coll.gameObject).z * 2000));
            bh.BurnDown();
        }
        else if (coll.transform.tag == "Flippers")
        {
            rb.AddForce(new Vector3(-GetDirection(coll.gameObject).x * 1000, (GetDirection(coll.gameObject).y - (GetDirection(coll.gameObject).y * 2)) * 1000, -GetDirection(coll.gameObject).z * 1000));
        }
        else
        {
            rb.AddForce(new Vector3(-GetDirection(coll.gameObject).x * 400, (GetDirection(coll.gameObject).y - (GetDirection(coll.gameObject).y * 2)) * 400, -GetDirection(coll.gameObject).z * 400));
        }

    }

    Vector3 GetDirection(GameObject collided)
    {
        Vector3 player = GameObject.FindWithTag("Player").transform.position;
        Vector3 target = collided.transform.position;
        Vector3 heading = target - player;
        float distance = heading.magnitude;
        Vector3 direction = heading / distance;

        return direction;
    }

}
