using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCollect : MonoBehaviour {
    // Global score
    public static int score = 500;

    //Post-condition: money collected
    //money prefeb destroyed
    void OnMouseDown()
    {
        // Increase Score
        score += 10;

        // Destroy coin
        Destroy(gameObject);
    }
}
