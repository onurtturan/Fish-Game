using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBox : Collect
{
    switchRB srb= new switchRB();


    public void OnTriggerEnter2D(Collider2D collision)
    {




        if (collision.gameObject.name == "fish_0" || collision.gameObject.name == "fish_2")
        {
            Destroy(gameObject);
            srb.DisableRagdoll();

            if(ChestKeySpawner.ud == 1)
            {
                //Instantiate(rchest1, new Vector3(10.5f, , 0), Quaternion.identity);

            }

            if (ChestKeySpawner.ud == 2)
            {

            }





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
