using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIntense : MonoBehaviour
{
    AudioSource source;
    Collider2D soundTrigger;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider2D>();
    }





    private void OnTriggerEnter2D(Collider2D collision)
    {
        source.Play();
    }
}

