using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Zombies;
	public GameObject Zombieboss;
	public GameObject CrazyZombies;
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
				Vector2 SpawnPositions2 = new Vector2(SpawnValuesX, Random.Range(SpawnValuesYLower, SpawnValuesYUpper));
				Vector2 SpawnPositions3 = new Vector2(SpawnValuesX, Random.Range(SpawnValuesYLower, SpawnValuesYUpper));
                Instantiate(Zombies, SpawnPositions, Quaternion.identity);
				Instantiate (Zombieboss, SpawnPositions2, Quaternion.identity);
				Instantiate (CrazyZombies, SpawnPositions3, Quaternion.identity);
                yield return new WaitForSeconds(TimeBetweenSpawns);
            }
            TimeBetweenWaves -= ReducedTimeBetWaves;
            ZombiesCount+=IncreaseZombies;
            yield return new WaitForSeconds(TimeBetweenWaves);
        }
    }
}