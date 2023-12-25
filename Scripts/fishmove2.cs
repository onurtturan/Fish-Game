using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fishMoveSecond : fishMove
{
    

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vector2 = new Vector2(0,force);
        if ( Input.GetKey(KeyCode.UpArrow)) {
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
        if (collision.gameObject.CompareTag("çöp"))
        {managerGame.DecreaseScore();
            audioSource2.Play();

        }

        /*if (collision.gameObject.CompareTag("sarmaþýk"))
        {
            managerGame.DecreaseScore();
            audioSource2.Play();
        }*/
        
    }
}
