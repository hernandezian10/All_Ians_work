using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VandF : MonoBehaviour
{
    int myInt = 5;
    // Start is called before the first frame update
    void Start()
    {
        int myInt = 10;
        myInt = multiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //This is for variables and functions 
    int multiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
