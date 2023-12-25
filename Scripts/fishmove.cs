using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fishMove : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public GameManager managerGame;
    public float force ;
    public AudioSource audioSource1;
    public AudioSource audioSource2;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(1, 0, 0);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vector2 = new Vector2(0,force);
        if ( Input.GetKey(KeyCode.W)) {
            rb2D.AddForce(vector2) ;
            
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {


        // Debug.Log("asfsa");

        if (collision.gameObject.CompareTag("yem"))
        {
            managerGame.IncreaseScore();
            audioSource1.Play();


        }

        if (collision.gameObject.CompareTag("box"))
        {
            audioSource1.Play();



        }

        if (collision.gameObject.CompareTag("çöp"))
        {
            managerGame.DecreaseScore();
            audioSource2.Play();

        }

        /*if (collision.gameObject.CompareTag("sarmaþýk"))
        {
            managerGame.DecreaseScore();
            audioSource2.Play();
        }*/

    }
}
