using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftMove : MonoBehaviour
{
    public float speed;

    
    void Start()
    {
        Destroy(gameObject, 8); 
    }

    void Update()
    {
        transform.position += Vector3.left*speed*Time.deltaTime;
        
    }

    

    }


