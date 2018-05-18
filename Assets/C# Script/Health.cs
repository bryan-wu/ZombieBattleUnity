using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    
    // Current Health
    [SerializeField]
    int cur = 5;

    //Post-condition: object's health get damaged
    // object destoried if health goes down to zero
    public void doDamage(int n)
    {
        // Subtract damage from current health
        cur -= n;

        // Destroy if died
        if (cur <= 0)
        {
            Destroy(gameObject);
            if (gameObject.tag == "Zombie")
            {
                MoneyCollect.score += 50;
            }

        }
    }
}
