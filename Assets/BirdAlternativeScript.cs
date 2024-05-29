using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AltBirdsScript : BirdScript
{
    public AudioClip sfx4;
    public AudioSource src;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
            flap2();

        }
    }
    public void flap2()
    { 
        src.clip = sfx4;
        src.Play();
    }
}

