using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {   
        float x = transform.position.x;

        // ScreenToWorldPoint = main camera method
        float y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;

        // Temporary variable since it is inside the method
        Vector2 tempPosition = new Vector2(x, y);

        // Position of Player 2
        transform.position = tempPosition;
    }
}
