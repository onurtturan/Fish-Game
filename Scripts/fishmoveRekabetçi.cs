using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fishMoveRekabetçi : fishMove
{
    
    public GameManagerRekabetçi managerGameRek;
   

    public void OnTriggerEnter2D(Collider2D collision)
    {


        

        if (collision.gameObject.CompareTag("yem"))
        {
            managerGameRek.IncreaseScoreTuruncu();
            audioSource1.Play();


        }
        if (collision.gameObject.CompareTag("çöp"))
        {
            managerGameRek.DecreaseScoreTuruncu();
            audioSource2.Play();

        }

        if (collision.gameObject.CompareTag("sarmaþýk"))
        {
            managerGameRek.DecreaseScoreTuruncu();
            audioSource2.Play();
        }

    }
}
