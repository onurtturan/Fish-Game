using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    [SerializeField] private KeyType keyType;

    public enum KeyType {
        ChestUp,
        ChestDown,
        FoodUp,
        FoodDown,
        WormUp,
        WormDown,
        StarUp,
        StarDown,
        HeartUp,
        HeartDown,
    }

    public KeyType GetKeyType() {
        return keyType;
    }

}
