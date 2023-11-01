using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour

    
{


    public GameObject obje;
public float height;
    public float time;

    void Start()
    {
        StartCoroutine(spawnYem(time));
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator spawnYem (float time)
    {

        while (true)
        {
            Instantiate(obje, new Vector3(10.5f, Random.Range(height, -height), 0), Quaternion.identity);
        
            yield return new WaitForSeconds(time);
        }

    }
}
