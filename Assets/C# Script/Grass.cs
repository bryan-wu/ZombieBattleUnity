using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour {
    void OnMouseUpAsButton()
    {
        // Is there something to build?
        if (BuildMenu.cur != null)
        {
            // Build it
            Instantiate(BuildMenu.cur.gameObject, transform.position, Quaternion.identity);
            MoneyCollect.score -= BuildMenu.cur.price;
            BuildMenu.cur = null;
        }
    }
}
