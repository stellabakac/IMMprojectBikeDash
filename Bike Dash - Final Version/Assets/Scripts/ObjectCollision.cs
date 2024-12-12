using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Rock"))
        {
            Debug.Log("Hit a Rock!");
            // Handle rock collision here (e.g., reduce health)
        }
        else if (other.CompareTag("Key"))
        {
            Debug.Log("Key Collected!");
            Destroy(other.gameObject); // Remove the key from the scene
            // You might want to add code here to update the player's inventory or score
        }
    }
}

