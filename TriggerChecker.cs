using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour {

    Rigidbody rb;
    public static bool gameOver;

	// Use this for initialization
	void Awake () {
        gameOver = false;
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeAll;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (!gameOver)
        {
            if (other.gameObject.tag == "Ball")
            {
                Invoke("FallDown", .4f);
                //FallDown();
            }
        }
    }

    void FallDown()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        rb.useGravity = true;
        Destroy(gameObject, 2f);
    }
}
