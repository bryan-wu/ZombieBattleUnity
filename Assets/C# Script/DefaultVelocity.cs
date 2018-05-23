using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultVelocity : MonoBehaviour {
    
    // The Velocity (can be set from Inspector)
    public Vector2 velocity;

    //Post-condition: object's velocity get set
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
    }
}
