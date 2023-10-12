using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class playerTracker : MonoBehaviour
{
    Vector3 moveForward;
    Vector3 moveLeftRight;
    public ratControl rat;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = rat.currentSpeed;
        transform.position = rat.transform.position - (transform.forward * 4.0f) + (Vector3.up * 1.5f);
        if (Input.GetMouseButton(0))
        {
            transform.RotateAround(rat.transform.position, transform.up, -Input.GetAxis("Mouse X") * speed);
        }
    }
}
