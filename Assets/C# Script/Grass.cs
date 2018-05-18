using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour {
    //post-condition: return false if there's already a soldier at position newPos
    //Otherwise return true
    bool CheckIfEmpty(Vector3 newPos)
    {
        GameObject[] zom = GameObject.FindGameObjectsWithTag("Ally");
        foreach(GameObject obj in zom)
        {
            if(obj.transform.position == newPos)
            {
                return false;
            }
        }
        return true;
    }
    //post-condition: selected soldier is placed at the grid clicked
    void OnMouseUpAsButton()
    {
        if (BuildMenu.cur != null)
        {
            Vector3 targetPos = transform.position;
            if (CheckIfEmpty(targetPos))
            {
                Instantiate(BuildMenu.cur.gameObject, targetPos, Quaternion.identity);
                MoneyCollect.score -= BuildMenu.cur.price;
                BuildMenu.cur = null;
            }
        }
    }
}
