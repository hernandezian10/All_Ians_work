using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrayChallenge : MonoBehaviour
{
    public string[] mystring = new string[] {"ian", "logan", "aaron"};
    public int[] myInt = new int[] { 1, 2, 3 };

    // Start is called before the first frame update
    void Start()
    {
        mystring[2] = "pedro";
        Debug.Log(mystring[2]);
        myInt[2] = 4;
        Debug.Log(myInt[2]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
