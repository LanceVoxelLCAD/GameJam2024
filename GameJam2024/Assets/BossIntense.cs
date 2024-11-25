using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIntense : MonoBehaviour
{
    AudioSource source;
    Collider2D soundTrigger;
    public bool isPlaying = false;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider2D>();
    }





    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isPlaying)
        {
            source.Play();
            isPlaying = true;
        }
        
    }
}

