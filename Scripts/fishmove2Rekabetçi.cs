using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fishMoveRekabetçiSecond : fishMove
{
    public GameManagerRekabetçi managerGameRek;

    void Update()
    {
        Vector2 vector2 = new Vector2(0, force);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb2D.AddForce(vector2);

        }

    }

    

    public void OnTriggerEnter2D(Collider2D collision)
    {


      
            
        if (collision.gameObject.CompareTag("yem"))
            {
            managerGameRek.IncreaseScoreMor();
            audioSource1.Play();


        }
        if (collision.gameObject.CompareTag("çöp"))
        {
            managerGameRek.DecreaseScoreMor();
            audioSource2.Play();

        }

        if (collision.gameObject.CompareTag("sarmaþýk"))
        {
            managerGameRek.DecreaseScoreMor();
            audioSource2.Play();
        }
        
    }
}
