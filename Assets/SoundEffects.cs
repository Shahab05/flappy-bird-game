using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public bool birdIsAlive = true;
    public AudioSource src;
    public AudioClip sfx1;


    public void flap()
    {
        src.clip = sfx1;
        src.Play();
    }
    
}
