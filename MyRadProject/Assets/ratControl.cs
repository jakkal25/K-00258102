using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratControl : MonoBehaviour
{
    float currentSpeed = 6;
    private float turningSpeed = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.rotation.eulerAngles.y > 180 && transform.rotation.eulerAngles.y < 358)
            {
                transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y <= 180 && transform.rotation.eulerAngles.y > 2)
            {
                transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y < 2)
            {
                transform.Rotate(Vector3.down, transform.rotation.eulerAngles.y);
                transform.position += currentSpeed * transform.forward * Time.deltaTime;
            }
            else
            {
                transform.Rotate(Vector3.up, 360 - transform.rotation.eulerAngles.y);
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (transform.rotation.eulerAngles.y < 178)
            {
                transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y > 182)
            {
                transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.up, 180 - transform.rotation.eulerAngles.y);
                transform.position += currentSpeed * transform.forward * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (transform.rotation.eulerAngles.y > 272 && transform.rotation.eulerAngles.y <= 90)
            {
                transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y < 268 && transform.rotation.eulerAngles.y > 90)
            {
                transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            }
            else 
            {
                transform.Rotate(Vector3.up, 270 - transform.rotation.eulerAngles.y);
                transform.position += currentSpeed * transform.forward * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.rotation.eulerAngles.y >= 270 && transform.rotation.eulerAngles.y < 88)
            {
                transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y < 270 && transform.rotation.eulerAngles.y > 92)
            {
                transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.up, 90 - transform.rotation.eulerAngles.y);
                transform.position += currentSpeed * transform.forward * Time.deltaTime;
            }
        }
    }
}
