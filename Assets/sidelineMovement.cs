using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sidelineMovement : MonoBehaviour
{
    // Movement speed of the player
    public float speed;

    // Upper and lower limits (top and bottom boundaries)
    public float upperLimit;
    public float lowerLimit;

    private Vector3 startPosition;

    void Start()
    {
        // Record the initial position of the player
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the movement using PingPong and offset it with the starting position
        float movement = Mathf.PingPong(Time.time * speed, upperLimit - lowerLimit) + lowerLimit;
        transform.position = new Vector3(startPosition.x, movement, startPosition.z);
    }
}


