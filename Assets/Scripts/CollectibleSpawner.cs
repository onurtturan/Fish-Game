using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public int time;
    public GameObject chestUp;
    public GameObject chestDown;
    public GameObject starUp;
    public GameObject starDown;
    public GameObject heartUp;
    public GameObject heartDown;
    public GameObject foodUp;
    public GameObject foodDown;
    public GameObject wormUp;
    public GameObject wormDown;

    public GameObject chestUpKey;
    public GameObject chestDownKey;
    public GameObject starUpKey;
    public GameObject starDownKey;
    public GameObject heartUpKey;
    public GameObject heartDownKey;
    public GameObject foodUpKey;
    public GameObject foodDownKey;
    public GameObject wormUpKey;
    public GameObject wormDownKey;


    void Start()
    {
        StartCoroutine(spawnCollectible(time));
    }

    public IEnumerator spawnCollectible(float time)
    {
        
        
        while (true)
        { 
            List<int> list = SixNumber.numberGive();
            int choosen= list[Random.Range(0, list.Count)];

            Instantiate(boxAssign(choosen), new Vector3(10.5f, -3.5f, 0), Quaternion.identity);
            yield return new WaitForSeconds(time);

            for (int i = 0; i < 6; i++)
            {
                Instantiate(collectibleAssign(list[i]), new Vector3(10.5f, 4.5f-(0.72f*i), 0), Quaternion.identity);
            }

            yield return new WaitForSeconds(time);

        }


        }


    public GameObject collectibleAssign(int indexNumber)
    {

        switch (indexNumber)
        {
            case 1:
                return chestUp;

            case 2:
                return chestDown;


            case 3:
                return starUp;


            case 4:
                return starDown;


            case 5:
                return heartUp;

            case 6:
                return heartDown;

            case 7:
                return foodUp;
            case 8:
                return foodDown;

            case 9:
                return wormUp;

            case 10:
                return wormDown;

            default:
                return null;

        }
    }

    public GameObject boxAssign(int indexNumber)
    {

        switch (indexNumber)
        {
            case 1:
                return chestUpKey;

            case 2:
                return chestDownKey;


            case 3:
                return starUpKey;


            case 4:
                return starDownKey;


            case 5:
                return heartUpKey;

            case 6:
                return heartDownKey;

            case 7:
                return foodUpKey;
            case 8:
                return foodDownKey;

            case 9:
                return wormUpKey;

            case 10:
                return wormDownKey;

            default:
                return null;

        }
    }






}
