using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildMenu : MonoBehaviour {
    // Coin Image
    public Texture moneyImage;

    // Soldiers Prefabs
    public BuildInfo[] allies;

    // Currently building
    public static BuildInfo cur;
//post-condition: shop is drawn with buttons that represent different soldiers vertically aligned
    void OnGUI() {
        GUILayout.BeginArea(new Rect(5, Screen.height/2 - 100, 100, 200));
        GUILayout.BeginVertical("box");
        GUILayout.Box(new GUIContent(MoneyCollect.score.ToString(), moneyImage));
        foreach (BuildInfo bi in allies) {
            bool canBuy = MoneyCollect.score >= bi.price;
            GUI.enabled = canBuy;
            if (GUILayout.Button(new GUIContent(bi.price.ToString(), bi.previewImage)))
            {
                cur = bi;
            }
            if (GameController.lose == true)
            {
                GUI.enabled = false;
            }
            else
			    GUI.enabled = true;

        }
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}
