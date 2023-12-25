using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectChest : Collect


{
    
    public void OnTriggerEnter2D(Collider2D collision)
    {

        

        if (collision.gameObject.name == "fish_0" || collision.gameObject.name == "fish_2")
        {
            Destroy(gameObject);



        }

    }
   
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
