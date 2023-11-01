using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class çöpSpawner : MonoBehaviour

    
{

    
    public GameObject çöp;
    
    public float height;
    public float time;

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
            Instantiate(çöp, new Vector3(10.5f, Random.Range(height, -height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }

    }
}
