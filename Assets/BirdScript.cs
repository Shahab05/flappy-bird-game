using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioClip sfx1, sfx3;
    public AudioSource src;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) 
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
            flap();

        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
        died();
    }

    public void flap()
    {
        src.clip = sfx1;
        src.Play();
    }

    public void died()
    {
        src.clip = sfx3;
        src.Play();
    }

}
