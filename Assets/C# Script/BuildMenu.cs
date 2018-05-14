using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMenu : MonoBehaviour {
    // Coin Image
    public Texture moneyImage;

    // Soldiers Prefabs
    public BuildInfo[] allies;

    // Currently building...
    public static BuildInfo cur;

    void OnGUI() {
        // Begin Gui
        GUILayout.BeginArea(new Rect(5, Screen.height/2 - 100, 100, 200));
        GUILayout.BeginVertical("box");

        // Draw the coin
        GUILayout.Box(new GUIContent(MoneyCollect.score.ToString(), moneyImage));

        // Draw each soldier's BuildInfo
        foreach (BuildInfo bi in allies) {
            GUI.enabled = MoneyCollect.score >= bi.price;
            if (GUILayout.Button(new GUIContent(bi.price.ToString(), bi.previewImage)))
                cur = bi;
        }

        // End Gui
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}
