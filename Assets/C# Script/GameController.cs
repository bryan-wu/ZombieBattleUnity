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
    //This gets called first automatically
    void Start()
    {
        StartCoroutine (SpawnZombies());
    }
    //post-condition: zombies are produced given the parameters that determin the rate of spawning and number of zombies spawned
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