using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionHandler : MonoBehaviour
{
    public Rigidbody rb;
    private BoxCollider2D groundCollider;

    private void Awake()
    {
        groundCollider = GameObject.FindWithTag("Ground").GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == groundCollider)
        {
            rb.velocity = Vector3.zero; // Stop the ball
            rb.useGravity = false; // Disable gravity for the ball
        }
    }
}
