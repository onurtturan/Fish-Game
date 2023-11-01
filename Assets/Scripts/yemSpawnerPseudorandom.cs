using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yemSpawnerPseudorandom : Spawner

    
{


    
    /*public float timeRange;
    public float timeWait;


    void Start()
    {
        StartCoroutine(spawnYem(timeRange, timeWait));
        yem.name = "yem";
        
    }

  

    public IEnumerator spawnYem (float timeR, float timeW)
    { 
        

        while (true)
        {
            
            float timeLast=Random.Range( timeW  , timeR);

            yield return new WaitForSeconds(timeLast);
            Instantiate(yem, new Vector3(10.5f, Random.Range(height, -height), 0), Quaternion.identity);
            yem.name = "yem";
            
            yield return new WaitForSeconds(timeR+timeW-timeLast);
        }

    }*/
}
