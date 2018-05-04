using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCollect : MonoBehaviour {
    // Global score
    public static int score = 110;

    void OnMouseDown()
    {
        // Increase Score
        score += 20;

        // Destroy Sun
        Destroy(gameObject);
    }
}
