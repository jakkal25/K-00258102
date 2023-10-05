using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SnowballControl : MonoBehaviour
{
    Rigidbody rb;
    internal int check = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 2, -4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void ImThrowingYou(humanControl humanControl)
    {
        transform.position = humanControl.transform.position + 2 * Vector3.up + 3 * humanControl.transform.forward;
        rb = GetComponent<Rigidbody>();
        rb.velocity = 10 * (2*Vector3.up + 3 * humanControl.transform.forward); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");
        DealWithHits thingIHit = collision.gameObject.GetComponent<DealWithHits>();
        if (thingIHit != null)
        {
            thingIHit.IHitYou();
        }
    }
}
