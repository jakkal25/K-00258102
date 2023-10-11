using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTracker : MonoBehaviour
{
    Vector3 moveForward;
    Vector3 moveLeftRight;
    public ratControl rat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void forwardMove(Vector3 forward, float speed)
    {
        transform.position += forward * Time.deltaTime * speed;
    }

    public void sideMove(Vector3 side, float speed)
    {
        transform.position += side * Time.deltaTime * speed;
    }

    public void diagionalMove(Vector3 forward, Vector3 side, float speed)
    {
        
    }
}
