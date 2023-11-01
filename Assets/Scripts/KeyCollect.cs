using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour {

    [SerializeField] private Key.KeyType keyType;


    public Key.KeyType GetKeyType() {
        return keyType;
    }

    public void DestroyCollectible() {
        gameObject.SetActive(false);

    }


}
