using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Keep track of animator
    private Animator animator;
    public float speed;

    // Static makes all instances of enemy refer to the same variable
    static private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        // Find the Animator
        animator = GetComponent<Animator>();
        direction = Vector2.right;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);

        if (transform.position.x > 10f)
        {
            direction = Vector2.left;
            MoveDown();
        }
        if (transform.position.x < -10f)
        {
            direction = Vector2.right;
            MoveDown();
        }
    }

    // OnCollisionEnter2D runs when given object collides with something else
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger("Death");

        // 1 second delay
        Destroy(gameObject, 1f);
        Destroy(collision.gameObject);
    }

    private void MoveDown()
    {
        foreach (Enemy enemy in FindObjectsOfType(typeof(Enemy)))
        {
            enemy.transform.Translate(Vector2.down);
        }
    }
}
