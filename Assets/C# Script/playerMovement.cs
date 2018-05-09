using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionStay2D(Collision2D coll)
    {
        // Collided with a Plant?
        if (coll.gameObject.tag == "Wall")
        {
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        if (Input.GetKey(KeyCode.A))
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        if (Input.GetKey(KeyCode.S))
            transform.position -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
    }
}
