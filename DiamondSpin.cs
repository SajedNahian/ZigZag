using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondSpin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print("hello?");
        transform.Rotate(Vector3.up, 7 * Time.deltaTime);
    }
}
