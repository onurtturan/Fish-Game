using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Key;

public class KeyHolder : MonoBehaviour {

    public GameManager managerGame;
    public SignalManager signalManager;
    public AudioSource audioSource1;

    

    private static List<Key.KeyType> keyList;

    private void Awake() {
        keyList = new List<Key.KeyType>();
    }

    public List<Key.KeyType> GetKeyList() {
        return keyList;
    }

    public void AddKey(Key.KeyType keyType) {
        Debug.Log("Added Key: " + keyType);
        keyList.Add(keyType);
        
    }

    public void RemoveKey(Key.KeyType keyType) {
        keyList.Remove(keyType);
        
    }

    public bool ContainsKey(Key.KeyType keyType) {
        return keyList.Contains(keyType);
    }


    private void OnTriggerEnter2D(Collider2D collider) {
        Key key = collider.GetComponent<Key>();
        if (key != null) {
            keyList.Clear();
            AddKey(key.GetKeyType());
            signalManager.UpdateSignal(key.GetKeyType());
            Destroy(key.gameObject);
            audioSource1.Play();
        }

        KeyCollect KeyCollect = collider.GetComponent<KeyCollect>();
        if (KeyCollect != null) {

            if (ContainsKey(KeyCollect.GetKeyType())) {
                managerGame.IncreaseScore();
                audioSource1.Play();
                RemoveKey(KeyCollect.GetKeyType());
                KeyCollect.DestroyCollectible();
            }

            else
            {
                Debug.Log("Bekleniyor");
                Invoke("deleteKey", 1f);
                
                //keyList.Clear();
            }

        }
    }

    private void deleteKey()
    {
        
        Debug.Log("Beklendi");
        keyList.Clear();

    }

}
