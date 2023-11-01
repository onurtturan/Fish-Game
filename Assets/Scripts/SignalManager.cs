using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class SignalManager : MonoBehaviour
{

    public Text signalText;
    //Key key = new Key();


    public void UpdateSignal(Key.KeyType kt)
    {
        switch (kt)
        {
            case Key.KeyType.ChestUp:
                signalText.text = "SANDIK \n YUKARI";
                break;
            case Key.KeyType.ChestDown:
                signalText.text = "SANDIK \n ASAGI";
                break;

            case Key.KeyType.FoodUp:
                signalText.text = "YEM \n YUKARI";
                break;

            case Key.KeyType.FoodDown:
                signalText.text = "YEM \n ASAGI";
                break;

            case Key.KeyType.WormUp:
                signalText.text = "SOLUCAN \n YUKARI";
                break;

            case Key.KeyType.WormDown:
                signalText.text = "SOLUCAN \n ASAGI";
                break;

            case Key.KeyType.StarUp:
                signalText.text = "YILDIZ \n YUKARI";
                break;

            case Key.KeyType.StarDown:
                signalText.text = "YILDIZ \n ASAGI";
                break;

            case Key.KeyType.HeartUp:
                signalText.text = "KALP \n YUKARI";
                break;

            case Key.KeyType.HeartDown:
                signalText.text = "KALP \n ASAGI";
                break;

            default:
                break;

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
