using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortGunFiring : Firing {
        
        public void Shoot()
        {
            if (zombieInFront())
            {

                //Play Shooting Sound
                FindObjectOfType<AudioManager>().Play(GunName);

                // Shooting Animation
                GetComponent<Animator>().SetTrigger("IsFiring");

                // Instantiate Bullet
                Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                Instantiate(bulletPrefab, transform.position + new Vector3(0.15f, 0.15f, 1), Quaternion.identity);
                Instantiate(bulletPrefab, transform.position - new Vector3(0.15f, 0.15f, 1), Quaternion.identity);
            }
        
        }

}
