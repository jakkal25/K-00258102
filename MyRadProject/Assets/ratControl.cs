using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratControl : MonoBehaviour
{
    float currentSpeed = 6;
    private float turningSpeed = 700;
    Rigidbody rb;
    Vector3 explosive = new Vector3(0, -5f, 0);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.freezeRotation = true;
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            if (transform.rotation.eulerAngles.y >= 235 && transform.rotation.eulerAngles.y < 43)
            {
                transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y < 235 && transform.rotation.eulerAngles.y > 47)
            {
                transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.up, 45 - transform.rotation.eulerAngles.y);
                transform.position += currentSpeed * transform.forward * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            if (transform.rotation.eulerAngles.y > 317 && transform.rotation.eulerAngles.y <= 135)
            {
                transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y < 313 && transform.rotation.eulerAngles.y > 135)
            {
                transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.up, 315 - transform.rotation.eulerAngles.y);
                transform.position += currentSpeed * transform.forward * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            if (transform.rotation.eulerAngles.y >= 315 && transform.rotation.eulerAngles.y < 133)
            {
                transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y < 315 && transform.rotation.eulerAngles.y > 137)
            {
                transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.up, 135 - transform.rotation.eulerAngles.y);
                transform.position += currentSpeed * transform.forward * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            if (transform.rotation.eulerAngles.y >= 45 && transform.rotation.eulerAngles.y < 223)
            {
                transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y < 45 && transform.rotation.eulerAngles.y > 227)
            {
                transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.up, 225 - transform.rotation.eulerAngles.y);
                transform.position += currentSpeed * transform.forward * Time.deltaTime;
            }
        }


        if (Input.GetKey(KeyCode.W) &! Input.GetKey(KeyCode.D) &! Input.GetKey(KeyCode.A))
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

        if (Input.GetKey(KeyCode.S) &! Input.GetKey(KeyCode.D) &! Input.GetKey(KeyCode.A))
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

        if (Input.GetKey(KeyCode.A) &! Input.GetKey(KeyCode.W) &! Input.GetKey(KeyCode.S))
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
        if (Input.GetKey(KeyCode.D) &! Input.GetKey(KeyCode.W) &! Input.GetKey(KeyCode.S))
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
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0f)
        {
            rb.AddExplosionForce(11000, transform.position + explosive, 5);
        }
    }
}
