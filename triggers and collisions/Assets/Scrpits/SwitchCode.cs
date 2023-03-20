using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCode : MonoBehaviour
{
    public int intelligence = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Greet ()
    {
        switch(intelligence)
        {
            case 5:
                print("Why hello there good sir! Let me teach you about Trigonomentry");
                break;
            case 4:
                print("hello and Good Day!");
                break;
            case 3:
                print("Lug, glib, plblblblbl");
                break;
            case 2:
                print("Grog SMASH!");
                break;
            case 1:
                print("ulg, glib, Pblblblblblblbbl");
                break;
            default:
                print("Incorrect intlligence level.");
                break;
        }
    }
}
