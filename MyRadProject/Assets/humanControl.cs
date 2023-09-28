using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humanControl : MonoBehaviour
{
    float currentSpeed, walkingSpeed = 2, runningSpeed = 4;
    private float turningSpeed = 180;
    Animator humanAnimator;
    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = walkingSpeed;
        humanAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        humanAnimator.SetBool("isWalking", false);
        if (Input.GetKey(KeyCode.W))
        {
            humanAnimator.SetBool("isWalking", true);
            transform.position += currentSpeed * transform.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S)) 
        {
            humanAnimator.SetBool("isWalking", true);
            transform.position -= currentSpeed * transform.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D)) 
        {
            transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
        }
    }
}
