using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchRB : MonoBehaviour
{

    private BoxCollider2D boxCollider;
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }
    public void EnableRagdoll()
    {
        boxCollider.isTrigger = true;
    }
    public void DisableRagdoll()
    {
        boxCollider.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
