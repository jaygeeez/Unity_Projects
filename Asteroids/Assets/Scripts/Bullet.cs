using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // Space.World make it translate rotate by world space instead of local space
        transform.Translate(transform.right * Time.deltaTime * speed, Space.World);
    }
}
