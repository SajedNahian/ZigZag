using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour {

    Rigidbody rb;
	// Use this for initialization
	void Awake () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Invoke("FallDown", .2f);
            //FallDown();
        }
    }

    void FallDown()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        rb.useGravity = true;
        Destroy(gameObject, 2f);
    }
}
