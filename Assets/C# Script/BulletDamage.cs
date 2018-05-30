using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour {

    //Pre-conditon: a bullet is fired and flying

    //Post-condition: collide with the object if it is a zombie
    //damage zombie's health by 1
    //destory the bullet

    [SerializeField]
    public int dmg;

    void OnTriggerEnter2D(Collider2D co)
    {
        // check if it's a zombie
        if (co.tag == "Zombie")
        {
            // Deal Damage, destroy Bullet
            co.GetComponent<Health>().doDamage(dmg);
            Destroy(gameObject);
        }
    }
}
