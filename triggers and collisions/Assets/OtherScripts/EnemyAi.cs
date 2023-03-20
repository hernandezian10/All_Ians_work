using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public List<Transform> points;
    public int nextID;
    public int idChangedValue = 1;
    public float speed = 2;
    // Start is called before the first frame update
    void MoveToNextPoint()
    {
        Transform goalPoint = points[nextID];

        if(goalPoint.transform.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
