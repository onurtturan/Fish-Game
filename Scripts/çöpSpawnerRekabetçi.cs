using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ��pSpawnerRekabet�i : ��pSpawner

    
{


    void Start()
    {
        StartCoroutine(spawn��p(time));
        ��p.name = "��p";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator spawn��p (float time)
    {

        while (true)
        {
            float ��pPosition = Random.Range(0.93f, height);
            yield return new WaitForSeconds(time);
            Instantiate(��p, new Vector3(10.5f, ��pPosition, 0), Quaternion.identity);
            Instantiate(��p, new Vector3(10.5f, ��pPosition-5.4f, 0), Quaternion.identity);
            
        }

    }
}
