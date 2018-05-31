using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text waveMes;
    public GameObject Zombies;
    public GameObject Zombieboss;
    public GameObject CrazyZombies;
    public float SpawnValuesX, TimeBetweenSpawns, TimeBetweenWaves, ReducedTimeBetWaves;
    public int ZombiesCount, IncreaseZombies, SpawnValuesYLower, SpawnValuesYUpper;
    //pos-condition: return false if they spawn at the same position
    //otherwise return true
    bool CheckBeforeSpawn(Vector3 newPos)
    {
        GameObject[] zom = GameObject.FindGameObjectsWithTag("Ally");
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
        StartCoroutine(SpawnZombies());
    }

    void resetScene()
    {
        SceneManager.LoadScene("project");
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
        GameObject[] zom = { Zombies, Zombieboss, CrazyZombies };
        while (TimeBetweenWaves > 0)
        {
            if (EnemyAttacking.ZombiesPassed <= 5)
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
                        Instantiate(obj, SpawnPositions, Quaternion.identity);
                    }
                    yield return new WaitForSeconds(TimeBetweenSpawns);
                }

                yield return StartCoroutine(WaveMessage("WARNING: new wave of zombies is here!", 2));
                TimeBetweenWaves -= ReducedTimeBetWaves;
                ZombiesCount += IncreaseZombies;
                yield return new WaitForSeconds(TimeBetweenWaves);


            }
            else
            {
                yield return StartCoroutine(WaveMessage("Game over. The zombies have taken over and you've lost :(", 5));
                yield return StartCoroutine(WaveMessage("", 1));
                resetScene();
                yield break;

            }

        }
        if (EnemyAttacking.ZombiesPassed <= 5)
        {
            yield return new WaitForSeconds(15);
            yield return StartCoroutine(WaveMessage("Congrats player, you've won!", 10));
        }
        //resetScene();
    }

}