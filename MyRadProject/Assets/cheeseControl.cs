using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheeseControl : MonoBehaviour
{
    Rigidbody rb;
    int turningSpeed = 150;
    public ratControl rat;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject != null)
        {
            rat.addHealth(20);
            Destroy(this.gameObject);
        }
    }
}
