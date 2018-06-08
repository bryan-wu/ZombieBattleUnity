using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    
    // Current Health
    [SerializeField]
	public float cur = 5;
	[SerializeField]
	public float ori_cur;

	public void increasehealth(float add_health){
		cur += add_health;
	}
	public void backhealth(float back_health){
		while (cur > ori_cur) {
			cur -= back_health;
		}
	}
    //Post-condition: object's health get damaged
    // object destoried if health goes down to zero
    public void doDamage(int n)
    {
        // Subtract damage from current health
        cur -= n;

        // Destroy if died
        if (cur <= 0)
        {
            Destroy(gameObject);
            if (gameObject.tag == "Zombie")
            {
                MoneyCollect.score += 10;
            }
            if(gameObject.tag == "Survivor")
            {
                GameController.lose = true;
            }
        }
    }
}
