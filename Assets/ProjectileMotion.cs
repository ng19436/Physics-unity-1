using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMotion : MonoBehaviour
{
    public float initialVelocity = 10f;
    public float initialAngle = 45f;
    public float gravity = -9.8f;
    public bool enabled = false;

    private Rigidbody rb;
    private float time;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        // Convert the initial angle to radians
        float angleInRadians = initialAngle * Mathf.Deg2Rad;

        // Calculate the initial velocities in x and y directions
        float initialVelocityX = initialVelocity * Mathf.Cos(angleInRadians);
        float initialVelocityY = initialVelocity * Mathf.Sin(angleInRadians);

        // Set the initial velocity of the ball
        rb.velocity = new Vector3(initialVelocityX, initialVelocityY, 0f);
    }

    private void FixedUpdate()
    {
        // Update the time
        if (!enabled)
            return;

        time += Time.fixedDeltaTime;

        // Calculate the new position of the ball based on projectile motion equations
        float newX = rb.velocity.x * time;
        float newY = rb.velocity.y * time + 0.5f * gravity * time * time;

        // Apply the new position to the ball
        rb.MovePosition(new Vector3(newX, newY, 0f));
    }
}
