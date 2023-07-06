using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject asteroid;
    public Transform[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        //Spawns rocks every 10 seconds
        InvokeRepeating("SpawnRocks", 0f, 10f);
    }

    private void SpawnRocks()
    {
        //Starts at 0 and stops when it reaches 4, so 4 loops total
        for (int i = 0; i < 4; i++)
        {
            Vector3 randomPosition = spawnPoints[Random.Range(0,3)].position;
            Instantiate(asteroid, randomPosition, Quaternion.identity);
        }
    }
}
