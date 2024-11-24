using UnityEngine;

public class NormalMusicOff : MonoBehaviour
{
    // Reference to the AudioSource that plays the music
    public AudioSource musicSource;

    // This method will be called when another collider enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger is the player (optional check)
        if (other.CompareTag("Player"))
        {
            // Stop the music
            if (musicSource != null)
            {
                musicSource.Stop(); // or musicSource.Pause() if you want to pause it instead of stopping
            }
        }
    }
}
