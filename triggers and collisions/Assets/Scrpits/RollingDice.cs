using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingDice : MonoBehaviour
{
    public int myInt;
    // Start is called before the first frame update
    void Start()
    {
        myInt = Random.Range(1, 7);
        switch (myInt)
        {
            case 1:
                Debug.Log("1");
                break;
            case 2:
                Debug.Log("2");
                break;
            case 3:
                Debug.Log("3");
                break;
            case 4:
                Debug.Log("4");
                break;
            case 5:
                Debug.Log("5");
                break;
            case 6:
                Debug.Log("6");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
