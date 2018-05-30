using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour {
    // The Bullet Prefab
    [SerializeField]
    public GameObject bulletPrefab;

    // Shooting Interval
    [SerializeField]
    public float interval = 0.5f;

    [SerializeField]
    public string GunName;

    // Use this for initialization
    public void Start()
    {
        // Try to shoot every few seconds
        InvokeRepeating("Shoot", 0, interval);
    }

    //Post-condition: True is returned if a zombie is in front
    //false is returned otherwise
    public bool zombieInFront()
    {
        // Raycast from the right of the game to the ally
        Vector2 origin = new Vector2(9.5f, transform.position.y);
        RaycastHit2D[] hits = Physics2D.RaycastAll(origin, -Vector2.right);

        // Find out if any Zombie was hit
        foreach (RaycastHit2D hit in hits)
        {
            if (hit.collider != null &&
                hit.collider.gameObject.tag == "Zombie")
                return true;
        }
        return false;
    }

    //Post-condition: soldier fire
     void Shoot()
    {
        if (zombieInFront())
        {

            //Play Shooting Sound
            FindObjectOfType<AudioManager>().Play(GunName);

            // Shooting Animation
            GetComponent<Animator>().SetTrigger("IsFiring");

            // Instantiate Bullet
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
}
