using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            Debug.Log("Key Collected!");
            
            // Play key sound
            AudioSource keyAudio = other.GetComponent<AudioSource>();
            if (keyAudio != null)
            {
                keyAudio.Play();
            }

            Destroy(other.gameObject, 0.5f); // Add a small delay to allow the sound to finish playing
        }
    }
}
