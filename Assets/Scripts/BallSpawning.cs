using UnityEngine;
using System.Collections;

public class BallSpawning : MonoBehaviour
{

    [SerializeField]
    private GameObject Ball;
    private Rigidbody rb;

    private bool exists = false;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnBall()
    {
        if(Ball != null)
        {
            rb = Ball.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(-500,0,0);
        }
        
    }

}