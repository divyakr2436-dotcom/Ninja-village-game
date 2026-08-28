using UnityEngine;

public class coin : MonoBehaviour
{
    // This function automatically runs when something enters the trigger collider
    private void OnTriggerEnter(Collider other) // Use OnTriggerEnter2D(Collider2D other) for 2D games
    {
        // Check if the object that touched the coin has the "Player" tag
        if (other.CompareTag("player"))
        {
            // Destroy the coin GameObject to make it disappear
            Destroy(gameObject);
        }
    }
}