using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class Player : MonoBehaviour
{
    private float speed = 5;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //up
            rb.velocity = new Vector2(0, speed);
            Debug.Log("up");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //down
            rb.velocity = new Vector2(0, -speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            // left
            rb.velocity = new Vector2(-speed, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            // right
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            // stop
            rb.velocity = Vector2.zero;
        }
        
        
    }
}
