using UnityEngine;
using System.Collections;

public class AudioFadeIn : MonoBehaviour
{
    public AudioSource audioSource;  // The AudioSource component
    public float fadeDuration = 2f;  // Duration of the fade-in effect

    private void Start()
    {
        if (audioSource != null)
        {
            // Start the fade-in coroutine when the script starts
            StartCoroutine(FadeInAudio());
        }
    }

    private IEnumerator FadeInAudio()
    {
        // Ensure the audio starts at volume 0
        audioSource.volume = 0;
        audioSource.Play();

        // Gradually increase the volume over time
        float targetVolume = 1f;  // Max volume
        float startVolume = audioSource.volume;

        float timeElapsed = 0f;

        while (timeElapsed < fadeDuration)
        {
            audioSource.volume = Mathf.Lerp(startVolume, targetVolume, timeElapsed / fadeDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }

        // Ensure the volume is set to the target volume after the fade
        audioSource.volume = targetVolume;
    }
}

