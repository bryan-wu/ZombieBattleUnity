using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySpawn : MonoBehaviour {

    public GameObject moneyPrefab;

    // Use this for initialization
    //Post-condition: Repeat spawning every time interval
    void Start()
    {
        // Spawn first Money in 10 seconds, repeat every 10 seconds
        InvokeRepeating("Spawn", 10, 10);
    }

    //Post-condition: generate a money prefab
    void Spawn()
    {
        // Load prefab into the Scene
        Instantiate(moneyPrefab,
                    transform.position,
                    Quaternion.identity);
    }
}
