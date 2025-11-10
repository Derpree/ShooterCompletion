using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy2 : MonoBehaviour
{
    public float speedX = 5f;
    public float speedY = 5f;
    public float timeKill = 10f;

    private Vector3 velocity;

    //doesn't go out of bounds
    private float horizontalLimit = 8f; 
    private float verticalLimit = 6.5f;

    void Start()
    {//automated velocity for movement
        velocity = new Vector3(speedX, speedY, 0);
        Destroy(gameObject, timeKill);
    }

    void Update()
    {
            // move enemy
            transform.Translate(velocity * Time.deltaTime);

            // check horizontal 
            if (transform.position.x > horizontalLimit || transform.position.x < -horizontalLimit)
                velocity.x *= -1;

            // check vertical 
            if (transform.position.y > verticalLimit || transform.position.y < 0) 
                velocity.y *= -1;
        }
    }

