using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlay : MonoBehaviour {

  //pre-condition: an music gameobject is ready and attached to scene
  //post-condition: background enter music is played seamlessly
   void Awake()
    {
        GameObject[] Musics = GameObject.FindGameObjectsWithTag("Music");

        if (Musics.Length > 1)
            Destroy(this.gameObject);            //check if there is more than one music playing
                                                 //if so, delete the current one so that keep the previous playing one

        DontDestroyOnLoad(this.gameObject);       
    }
}
