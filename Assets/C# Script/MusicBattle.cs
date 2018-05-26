using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBattle : MonoBehaviour {

    void Awake()
    {
        GameObject[] Musics = GameObject.FindGameObjectsWithTag("Music");

        foreach(GameObject mus in Musics)
            Destroy(mus);

    }
}
