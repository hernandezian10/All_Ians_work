using UnityEngine;

public class Challenge : MonoBehaviour
{
    bool weaponEqquiped = true;
    string weaponType = "sword";
    // Start is called before the first frame update
    void Start()
    {
        if (weaponEqquiped == true)
        {
            if (weaponType == "sword")
            {
                Debug.Log("Battle Cry");
            }
            else
            {
                Debug.Log("you need a sword");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
