using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   
    public GameObject Enemy;

    // Spacing between bricks
    public float xSpace;

    // Change spawn position
    public float xOffset;

    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < 10; x++)
        {
            // Instantiate spawns objects (spawning object, position to spawn, rotation)
            Instantiate(Enemy, new Vector2(x * xSpace + xOffset, 3), Quaternion.identity);
            Instantiate(Enemy, new Vector2(x * xSpace + xOffset, 3.75f), Quaternion.identity);
            Instantiate(Enemy, new Vector2(x * xSpace + xOffset, 4.5f), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
