using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    [SerializeField]
    private float speed;
    private bool gameStarted, gameOver;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        gameStarted = false;
        gameOver = false;
    }
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0) && !gameOver)
        {
            if (gameStarted)
            {
                SwitchDirection();
            } else
            {
                gameStarted = true;
                rb.velocity = new Vector3(speed, 0, 0);
            }
        }

        if (!Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            gameOver = true;
            rb.velocity = new Vector3(0, -18f, 0);

            Camera.main.GetComponent<CameraFollow>().gameOver = true;
        }
	}

    void SwitchDirection ()
    {
        if (rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed, 0, 0);
        } else
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
    }
}
