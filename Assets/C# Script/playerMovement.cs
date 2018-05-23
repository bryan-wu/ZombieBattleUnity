using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    //Player's moveing speed
    public float speed;

	// Use this for initialization
	void Start() {
		
	}

    //Test code for futher improvement, ignore now
    /*void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Wall")
        {
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }*/


    // Update is called once per frame
    //Pre-Condition:Player prefab is ready on the screen
    //User has a keyboard for valid input
    //The game is now running

    //Post-Condition: Player prefab makes movement according to user's input
    void Update () {
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f); //move right
        if (Input.GetKey(KeyCode.A))
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f); //move left
        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f); //move up
        if (Input.GetKey(KeyCode.S))
            transform.position -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f); //move down
    }
}
