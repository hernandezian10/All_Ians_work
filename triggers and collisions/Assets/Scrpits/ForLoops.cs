using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    public string[] questParty = new string[] {"Merlin the Star", "Grin the Barbarian", "Steerling the Night"};
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i< questParty.Length; i++)
        {
            Debug.Log(questParty[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
