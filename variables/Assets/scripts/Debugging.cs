using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugging : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Test("This a test!!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This it to test our code
    void Test(string message)
    {
        Debug.Log(message);
    }
}
