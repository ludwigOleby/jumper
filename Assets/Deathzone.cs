using UnityEngine;

public class Deathzone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Player has entered the deathzone, handle death logic here
            // For example, reset the game or show a game over screen
        }
    }
}
