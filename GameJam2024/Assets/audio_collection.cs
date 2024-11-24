using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_collection : MonoBehaviour
{
    AudioSource source;
    Collider2D soundtrigger;
    bool hasPlayed = false; // Flag to track if the sound has played

    void Awake()
    {
        source = GetComponent<AudioSource>();
        soundtrigger = GetComponent<Collider2D>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // Check if the sound has already played
        if (!hasPlayed)
        {
            source.Play(); // Play the sound
            hasPlayed = true; // Set the flag to true so the sound won't play again
        }
    }
}