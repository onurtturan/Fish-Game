using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ��pSpawnerHaz�rl�k3 : ��pSpawner

    
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
            Instantiate(��p, new Vector3(10.5f, Random.Range(height, -height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }

    }
}
