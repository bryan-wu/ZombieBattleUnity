using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuButtons : MonoBehaviour {

public void SwitchPage (string pageName)
    {
        SceneManager.LoadScene(pageName, LoadSceneMode.Single);
    }
}
