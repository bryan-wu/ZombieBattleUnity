using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
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
        StartCoroutine (SpawnZombies());
    }
    //post-condition: zombies are produced given the parameters that determin the rate of spawning and number of zombies spawned
    IEnumerator SpawnZombies()
    {
        GameObject[] zom = { Zombies, Zombieboss, CrazyZombies };
        while (TimeBetweenWaves>0)
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
            TimeBetweenWaves -= ReducedTimeBetWaves;
            ZombiesCount+=IncreaseZombies;
            yield return new WaitForSeconds(TimeBetweenWaves);
        }
    }
}