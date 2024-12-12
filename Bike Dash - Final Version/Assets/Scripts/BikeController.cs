using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{
    public float speed = 10f; // Speed of the bike
    public float turnSpeed = 100f; // Turning speed of the bike
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody component is missing from this GameObject.");
            return; // Exit if Rigidbody is missing
        }
    }

    private void FixedUpdate()
    {
        if (rb != null)
        {
            // Get input for movement
            float moveInput = Input.GetAxis("Vertical"); // W/S or Up/Down arrows
            float turnInput = Input.GetAxis("Horizontal"); // A/D or Left/Right arrows

            // Calculate movement and turning
            Vector3 movement = transform.forward * moveInput * speed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + movement);

            // Calculate rotation
            float turn = turnInput * turnSpeed * Time.fixedDeltaTime;
            Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
            rb.MoveRotation(rb.rotation * turnRotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered with: " + other.name); // Log the name of the object collided with

        if (other.CompareTag("Rock"))
        {
            Debug.Log("Hit a Rock!");
            // Add any additional logic for hitting a rock here
        }
        else if (other.CompareTag("Key"))
        {
            Debug.Log("Key Collected!");
            Destroy(other.gameObject); // Destroy the key object
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision with: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Rock"))
        {
            Debug.Log("Hit a Rock!");
            // Add any additional logic for hitting a rock here, e.g., stopping the bike
        }
    }
}
