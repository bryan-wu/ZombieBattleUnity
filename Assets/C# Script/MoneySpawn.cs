using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySpawn : MonoBehaviour {

    //Prefab of Sun
    public GameObject SunPrefab;

    // Use this for initialization
    //Post-condition: Repeat spawning every time interval
    void Start()
    {
        // Spawn first Money in 10 seconds, repeat every 10 seconds
        InvokeRepeating("Spawn", 10, 10);
    }

    //Post-condition: generate a sun prefab
    void Spawn()
    {
        // Load prefab into the Scene
        Instantiate(SunPrefab,
                    transform.position,
                    Quaternion.identity);
    }
}
