using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class ChestKeySpawner : MonoBehaviour
{
    
    
    void Start()
    {
        StartCoroutine(spawnChest(time));


    }

     int color1;
     int color2;
     int color3;

    public GameObject rchest1;
    public GameObject rchest2;
    public GameObject rchest3;

    public static int ud = 0;

    public GameObject chest1;
    public GameObject chest2;
    public GameObject chest3;
    public GameObject chest4;
    public GameObject chest5;
    public GameObject box;
    //public float height;
    public float time;

    



    public IEnumerator spawnChest(float time)
    {
        
        

        while (true)
        { 
            ud = Random.Range(1, 3);
            float heightup1 = heightPicker(2.65f, 4.1f, 1.2f, 0);
            float heightup2 = heightPicker(2.65f, 4.1f, 1.2f, heightup1);
            float heightup3 = heightPicker(2.65f, 4.1f, 1.2f, heightup1, heightup2);

            float heightdown1 = heightPicker(-2.65f, -4.1f, -1.2f, 0);
            float heightdown2 = heightPicker(-2.65f, -4.1f, -1.2f, heightdown1);
            float heightdown3 = heightPicker(-2.65f, -4.1f, -1.2f, heightdown1, heightdown2);

            colorAssign(ref color1, ref color2, ref color3);


            if (ud==1)
        {
            yield return new WaitForSeconds(time);

            Instantiate(box, new Vector3(10.5f, 2.65f, 0), Quaternion.identity);

            yield return new WaitForSeconds(time);

                rchest1 = chestAssign(color1);
                rchest2 = chestAssign(color2);
                rchest3 = chestAssign(color3);

            Instantiate(rchest1, new Vector3(10.5f, heightdown1, 0), Quaternion.identity);
            Instantiate(rchest2, new Vector3(10.5f, heightdown2, 0), Quaternion.identity);
            Instantiate(rchest3, new Vector3(10.5f, heightdown3, 0), Quaternion.identity);
                

            }

        else if (ud==2)
        {

                yield return new WaitForSeconds(time);
            Instantiate(box, new Vector3(10.5f, -2.65f, 0), Quaternion.identity);
                yield return new WaitForSeconds(time);

                rchest1 = chestAssign(color1);
                rchest2 = chestAssign(color2);
                rchest3 = chestAssign(color3);

            Instantiate(rchest1, new Vector3(10.5f, heightup1, 0), Quaternion.identity);
            Instantiate(rchest2, new Vector3(10.5f, heightup2, 0), Quaternion.identity);
            Instantiate(rchest3, new Vector3(10.5f, heightup3, 0), Quaternion.identity);

        }

            
        }

    }


    static void colorAssign(ref int color1, ref int color2, ref int color3)
    {
        color1 = Random.Range(1, 6);


        switch (color1)
        {
            case 1:
                color2 = colorPicker(color1);
                color3 = colorPicker(color1, color2);
                break;

            case 2:
                color2 = colorPicker(color1);
                color3 = colorPicker(color1, color2);
                break;

            case 3:
                color2 = colorPicker(color1);
                color3 = colorPicker(color1, color2);
                break;

            case 4:
                color2 = colorPicker(color1);
                color3 = colorPicker(color1, color2);
                break;

            case 5:
                color2 = colorPicker(color1);
                color3 = colorPicker(color1, color2);
                break;
        }
    }

    public GameObject chestAssign(int color)
    {

        switch (color)
        {
            case 1:
                return chest1;

            case 2:
                return chest2;
                

            case 3:
                return chest3;
                

            case 4:
                return chest4;
                

            case 5:
                return chest5;
                
            default:
            return null;
        
        }
    }



    


    static int colorPicker(int colorx)
    {
        int colorTemp;
        do
        {
            colorTemp = Random.Range(1, 6);
        }
        while (colorTemp == colorx);

        return colorTemp;
    }

    static int colorPicker(int colorx, int colory)
    {
        int colorTemp;
        do
        {
            colorTemp = Random.Range(1, 6);
        }
        while (colorTemp == colorx || colorTemp == colory);

        return colorTemp;
    }

    static float heightPicker(float height1, float height2, float height3, float heightx)
    {
        float heightTemp;
        do
        {
            heightTemp = randomChoose( height1,  height2,  height3);
            //heightTemp = Random.Range(1, 5);
        }
        while (heightTemp == heightx);

        return heightTemp;
    }


    static float heightPicker(float height1, float height2, float height3, float heightx, float heighty)
    {
        float heightTemp;
        do
        {
            //heightTemp = randomChoose();
            heightTemp = randomChoose( height1,  height2,  height3);
            //heightTemp = Random.Range(1, 5);
        }
        while (heightTemp == heightx || heightTemp == heighty);

        return heightTemp;
    }

    static float randomChoose(float one, float two, float three)
    {
        
        float[] arr = new float[3] { one, two, three };
        int ix = Random.Range(0,3) ;
        return arr[ix];
    }





    void Update()
    {

    }






}
