using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour {

    [SerializeField]
    public GameObject platformPrefab, diamonds; 
    Vector3 lastPos;
    float size;
    public static bool gameOver;


	// Use this for initialization
	void Awake () {
        size = platformPrefab.transform.localScale.x;
        lastPos = transform.position;

        for (int i = 0; i < 50; i ++)
        {
            SpawnPlatform();
        }

        InvokeRepeating("SpawnPlatform", 1f, .2f);
    }
	
	// Update is called once per frame
	void Update () {
       if (gameOver)
        {
            CancelInvoke("SpawnPlatform");
        }
	}

    void SpawnPlatform ()
    {
        int rand = Random.Range(0, 6);
        if (rand < 3)
        {
            SpawnX();
        } else
        {
            SpawnZ();
        }
    }

    void SpawnX ()
    {
        Vector3 pos = lastPos;
        pos.x += size;
        Instantiate(platformPrefab, pos, Quaternion.identity);
        lastPos = pos;
        if (Random.Range(0,4) < 1)
        {
            pos.y += 1.2f;
            Instantiate(diamonds, pos, Quaternion.Euler(45f,0,45f));
        }
    }

    void SpawnZ ()
    {
        Vector3 pos = lastPos;
        pos.z += size;
        Instantiate(platformPrefab, pos, Quaternion.identity);
        lastPos = pos;
        if (Random.Range(0, 4) < 1)
        {
            pos.y += 1.2f;
            Instantiate(diamonds, pos, Quaternion.Euler(45f, 0, 45f));
        }
    }
}
