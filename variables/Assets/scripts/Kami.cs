using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kami : MonoBehaviour
{
    public int number1 = 1;
    public int number2 = 2;
    // Start is called before the first frame update
    void Start()
    {
        int myInt;
        myInt = AddTogether(number1, number2);
        Debug.Log(myInt);
    }

 

    // Update is called once per frame
    void Update()
    {
       
    }

    //returning the numbers
    int AddTogether(int number1, int number2)
    {
        int result;
        result = (number1 + number2);
        return result;
    }
    

}
