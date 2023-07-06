using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float lookSpeed;
    public float moveSpeed;
    public float maxSpeed;
    private Rigidbody2D rb;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Rotate around the Z axis
            transform.Rotate(Vector3.forward * Time.deltaTime * lookSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back * Time.deltaTime * lookSpeed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 velocity = rb.velocity;
            velocity = velocity + transform.right * Time.deltaTime * moveSpeed;

            // ClampMagnitude sets a speed limit
            Vector3.ClampMagnitude(velocity, maxSpeed);

            rb.velocity = velocity;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
