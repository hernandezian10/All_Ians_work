using UnityEngine;

public class HookGetsFish : MonoBehaviour
{
    private float stopFishX = -10f;


    public float xRange = 10;
    
    Rigidbody fishRigidBody;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerEnter(Collider col)
    {
        fishRigidBody = GetComponent<Rigidbody>();
        fishRigidBody.useGravity = true;
        //stops fish when the hooks hits it but the sceen stills moves
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.Translate(Vector3.right * Time.deltaTime * -stopFishX);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Translate(Vector3.left * Time.deltaTime * -stopFishX);

        }
    }

}
