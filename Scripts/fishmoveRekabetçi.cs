using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fishMoveRekabet�i : fishMove
{
    
    public GameManagerRekabet�i managerGameRek;
   

    public void OnTriggerEnter2D(Collider2D collision)
    {


        

        if (collision.gameObject.CompareTag("yem"))
        {
            managerGameRek.IncreaseScoreTuruncu();
            audioSource1.Play();


        }
        if (collision.gameObject.CompareTag("��p"))
        {
            managerGameRek.DecreaseScoreTuruncu();
            audioSource2.Play();

        }

        if (collision.gameObject.CompareTag("sarma��k"))
        {
            managerGameRek.DecreaseScoreTuruncu();
            audioSource2.Play();
        }

    }
}
