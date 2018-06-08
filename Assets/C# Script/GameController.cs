using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text waveMes,loseMes, winMes;
    public GameObject Zombies;
    public GameObject Zombieboss;
    public GameObject CrazyZombies;
    public GameObject HotDog;
	public float SpawnValuesX, TimeBetweenSpawns, TimeBetweenWaves, ReducedTimeBetWaves, increase_health;
    public int ZombiesCount, IncreaseZombies, SpawnValuesYLower, SpawnValuesYUpper;
    public static bool lose, win;
    //pos-condition: return false if they spawn at the same position
    //otherwise return true
    bool CheckBeforeSpawn(Vector3 newPos)
    {
        GameObject[] zom = GameObject.FindGameObjectsWithTag("Zombie");
        foreach (GameObject obj in zom)
        {
            if (obj.transform.position == newPos)
            {
                return false;
            }
        }
        return true;
    }
    //This gets called first automatically
    void Start()
    {
        loseMes.text = "";
        lose = false;
        winMes.text = "";
        win = false;
        StartCoroutine(SpawnZombies());
    }
    //This gets called every frame
    void Update()
    {
        GameObject[] zombiesEnd = GameObject.FindGameObjectsWithTag("Zombie");
		GameObject[] zom = { Zombies, Zombieboss, CrazyZombies, HotDog };
        foreach (GameObject obj in zombiesEnd)
        {
            if (obj.transform.position.x <= 0)
            {
                Destroy(obj);
                EnemyAttacking.ZombiesPassed++;
            }
        }

        if (EnemyAttacking.ZombiesPassed >= 10)
        {
            lose = true;
        }

        GameObject[] bulletsEnd = GameObject.FindGameObjectsWithTag("Bullet");
        foreach (GameObject obj in bulletsEnd)
        {
            if (obj.transform.position.x >= 10.5)
                Destroy(obj);
        }

        if (lose)
        {
            //Play Losing Sound
            FindObjectOfType<AudioManager>().Play("MoneySpawn");
            //FindObjectOfType<AudioManager>().Play("Defeat");
            FindObjectOfType<AudioManager>().Mute("ZombieSpawn");
            waveMes.text = "";
            loseMes.text = "You lost the game! Press 'N' to restart the game";
			foreach (GameObject obj in zom) {
				obj.GetComponent<Health> ().backhealth (increase_health);
			}
            foreach (GameObject obj in zombiesEnd)
            {
                    Destroy(obj);
            }
            if (Input.GetKey(KeyCode.N))
            {
                MoneyCollect.score = 500;
                EnemyAttacking.ZombiesPassed = 0;
                SceneManager.LoadScene("project");
            }
        }
       
        if (TimeBetweenWaves == 0 && lose == false)
        {

            if (zombiesEnd.Length == 0)
            {
                win = true;
            }
        }

        if (win)
        {
            FindObjectOfType<AudioManager>().Play("Victory");
            winMes.text = "";
            winMes.text = "You've won the game! Press 'N' to restart the game";
			foreach (GameObject obj in zom) {
				obj.GetComponent<Health> ().backhealth (increase_health);
			}
			foreach (GameObject obj in zombiesEnd)
			{
				Destroy(obj);
			}
            if (Input.GetKey(KeyCode.N))
            {
                MoneyCollect.score = 500;
                EnemyAttacking.ZombiesPassed = 0;
                SceneManager.LoadScene("project");
            }
        }
    }


    IEnumerator WaveMessage(string message, float displayTime)
    {
        waveMes.text = message;
        waveMes.enabled = true;
        yield return new WaitForSeconds(displayTime);
        waveMes.enabled = false;
    }
    //post-condition: zombies are produced given the parameters that determin the rate of spawning and number of zombies spawned
    IEnumerator SpawnZombies()
    {
        GameObject[] zom = { Zombies, Zombieboss, CrazyZombies, HotDog };
        while ((TimeBetweenWaves > 0) && (!lose))
        {
            for (int i = 0; i < ZombiesCount; i++)
            {

                foreach (GameObject obj in zom)
                {
                    Vector3 SpawnPositions = new Vector3(SpawnValuesX, Random.Range(SpawnValuesYLower, SpawnValuesYUpper));
                    while (CheckBeforeSpawn(SpawnPositions) == false)
                    {
                        SpawnPositions = new Vector3(SpawnValuesX, Random.Range(SpawnValuesYLower, SpawnValuesYUpper));
                    }
					obj.GetComponent<Health> ().increasehealth (increase_health);
                    Instantiate(obj, SpawnPositions, Quaternion.identity);
                }
                yield return new WaitForSeconds(TimeBetweenSpawns);
            }

            //Play Zombie Wave Sound
            FindObjectOfType<AudioManager>().Play("ZombieSpawn");

            yield return StartCoroutine(WaveMessage("WARNING: A new wave of zombies is here!", 2));
            TimeBetweenWaves -= ReducedTimeBetWaves;
            ZombiesCount += IncreaseZombies;
            yield return new WaitForSeconds(TimeBetweenWaves);


         
        }
    }

}