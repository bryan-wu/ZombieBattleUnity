using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject OrangeLavaSnake;
    public float SpawnValuesX,TimeBetweenSpawns,TimeBetweenWaves, ReducedTimeBetWaves;
    public int ZombiesCount, IncreaseZombies,SpawnValuesYLower, SpawnValuesYUpper;
    // Use this for initialization
    void Start()
    {
        StartCoroutine (SpawnZombies());
    }
    IEnumerator SpawnZombies()
    {
        while (TimeBetweenWaves>0)
        {
            for (int i = 0; i < ZombiesCount; i++)
            {
                Vector2 SpawnPositions = new Vector2(SpawnValuesX, Random.Range(SpawnValuesYLower, SpawnValuesYUpper));
                Instantiate(OrangeLavaSnake, SpawnPositions, Quaternion.identity);
                yield return new WaitForSeconds(TimeBetweenSpawns);
            }
            TimeBetweenWaves -= ReducedTimeBetWaves;
            ZombiesCount+=IncreaseZombies;
            yield return new WaitForSeconds(TimeBetweenWaves);
        }
    }
}