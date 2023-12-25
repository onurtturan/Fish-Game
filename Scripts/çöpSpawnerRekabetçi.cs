using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class çöpSpawnerRekabetçi : çöpSpawner

    
{


    void Start()
    {
        StartCoroutine(spawnÇöp(time));
        çöp.name = "çöp";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator spawnÇöp (float time)
    {

        while (true)
        {
            float çöpPosition = Random.Range(0.93f, height);
            yield return new WaitForSeconds(time);
            Instantiate(çöp, new Vector3(10.5f, çöpPosition, 0), Quaternion.identity);
            Instantiate(çöp, new Vector3(10.5f, çöpPosition-5.4f, 0), Quaternion.identity);
            
        }

    }
}
