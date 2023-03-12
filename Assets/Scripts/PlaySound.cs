using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource soundPlayer;
    public Rigidbody2D rb;

    void Start()
    {
        soundPlayer = GetComponent<AudioSource>();
    }



    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Frog")
        {
            soundPlayer.Play();
        }
    }

    void Update()
    {
       // if (Input.GetMouseButtonDown(0) == true)
      //  {
       //     GetComponent<AudioSource>().Play();
       // }
    }
}
