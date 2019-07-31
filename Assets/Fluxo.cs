using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fluxo : MonoBehaviour {

    public float speed;
    public GameObject prefab;
    // Use this for initialization
    void Start () {
        Vector3 inic = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        Vector2 pos = transform.position;
        pos.x = pos.x - speed * Time.deltaTime;
        transform.position = pos;

        if (transform.position.x < -18.64)
        {
            Vector2 groundofset = new Vector2(29.3f, 0);
            transform.position = (Vector2) groundofset;
        }
    }
}
