using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    /// <summary>
    /// The speed of the ship
    /// </summary>
    public Vector2 speed = new Vector2(50, 50);

    // Store the movement and the component
    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;

    void Update()
    {
        // Retrieve axis information
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // Movement per direction
        movement = new Vector2(
          speed.x * inputX,
          speed.y * inputY);

    }

    void FixedUpdate()
    {
        // Get the component and store the reference
        if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

        // Move the game object
        rigidbodyComponent.velocity = movement;
    }
}