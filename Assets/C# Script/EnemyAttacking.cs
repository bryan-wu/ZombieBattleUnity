﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttacking : MonoBehaviour {
    // Last Attack Time
    float last = 0;

    //Post-condition: zombie attacked a soldier
    void OnTriggerEnter2D(Collider2D coll)
    {
        // check if it collided with a soldier
        if (coll.gameObject.tag == "Ally")
        {
            // Play Attack Animation
            GetComponent<Animator>().SetTrigger("IsAttacking");
            // Deal damage once a second
            if (Time.time - last >= 1)
            {
                coll.gameObject.GetComponent<Health>().doDamage(1);
                last = Time.time;
            }
        }
    }
}
