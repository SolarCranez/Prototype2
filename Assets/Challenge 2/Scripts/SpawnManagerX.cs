using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    // array of ballPrefabs
    public GameObject[] ballPrefabs;

    // variables for spawn position limits
    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    // variables for spawn-time and delay between spawns
    private float startDelay = 1.0f;
    private float spawnInterval = 3;

    // Start is called before the first frame update
    void Start()
    {
        // invokes method SpawnRandomBall in [startDelay] seconds, then repeatedly invokes again based on a random range from spawnInterval to spawnInterval+2
        InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(spawnInterval, spawnInterval+2));
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
