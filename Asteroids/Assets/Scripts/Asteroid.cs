using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Asteroid : MonoBehaviour
{
    public float speed;
    public float minSize;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        // If above minSize, spawn a copy of current game object
        if(transform.localScale.x > minSize)
        {
            transform.localScale = transform.localScale * 0.5f;
            Instantiate(gameObject, transform.position, Quaternion.identity);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
}
