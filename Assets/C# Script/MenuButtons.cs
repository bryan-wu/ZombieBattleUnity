using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuButtons : MonoBehaviour {
//post-condition: switch to a new page given the name of destination page
public void SwitchPage (string pageName)
    {
        SceneManager.LoadScene(pageName, LoadSceneMode.Single);
    }
}
