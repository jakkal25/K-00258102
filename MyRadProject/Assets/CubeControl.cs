using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    Rigidbody myRB;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        //transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            myRB.AddForce(transform.forward);
            //transform.position += Vector3.forward * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRB.AddExplosionForce(20, transform.position + Vector3.down,5 );
        }

        if (Input.GetKey(KeyCode.S))
        {
            myRB.AddForce(-2 * transform.forward);
            //transform.position += Vector3.back * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate (Vector3.up, -90 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate (Vector3.up, 90 * Time.deltaTime);
        }
    }
}
