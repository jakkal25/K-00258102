using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratControl : MonoBehaviour
{
    public float currentSpeed = 6;
    private float turningSpeed = 700;
    Rigidbody rb;
    Vector3 explosive = new Vector3(0, -5f, 0);
    float maxRatHealth = 100.0f;
    float ratHealth;
    public Health healthBar;
    public playerTracker cam;
    float camRot;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ratHealth = maxRatHealth;
        healthBar.MaxHealth(maxRatHealth);
    }

    // Update is called once per frame
    void Update()
    {
        camRot = cam.transform.rotation.eulerAngles.y;
        rb.freezeRotation = true;
        ratHealth -= (12 * Time.deltaTime);
        healthBar.setHealth(ratHealth);
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            if (transform.rotation.eulerAngles.y >= ((235 + camRot + 360) % 360) && transform.rotation.eulerAngles.y < ((43 + camRot + 360) % 360))
            {
                transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y < ((235 + camRot + 360) % 360) && transform.rotation.eulerAngles.y > ((47 + camRot + 360) % 360))
            {
                transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.up, ((45 + camRot + 360) % 360) - transform.rotation.eulerAngles.y);
                transform.position += currentSpeed * transform.forward * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            if (transform.rotation.eulerAngles.y > ((317 + camRot + 360) % 360) && transform.rotation.eulerAngles.y <= ((135+ camRot + 360) % 360))
            {
                transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y < ((313 + camRot + 360) % 360) && transform.rotation.eulerAngles.y > ((135 + camRot + 360) % 360))
            {
                transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.up, ((315 + camRot + 360) % 360) - transform.rotation.eulerAngles.y);
                transform.position += currentSpeed * transform.forward * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            if (transform.rotation.eulerAngles.y >= ((315 + camRot + 360) % 360) && transform.rotation.eulerAngles.y < ((133 + camRot + 360) % 360))
            {
                transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y < ((315 + camRot + 360) % 360) && transform.rotation.eulerAngles.y > ((137 + camRot + 360) % 360))
            {
                transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.up, ((135 + camRot + 360) % 360) - transform.rotation.eulerAngles.y);
                transform.position += currentSpeed * transform.forward * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            if (transform.rotation.eulerAngles.y >= ((45 + camRot + 360) % 360) && transform.rotation.eulerAngles.y < ((223 + camRot + 360) % 360))
            {
                transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y < ((45 + camRot + 360) % 360) && transform.rotation.eulerAngles.y > ((227 + camRot + 360) % 360))
            {
                transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.up, ((225 + camRot + 360) % 360) - transform.rotation.eulerAngles.y);
                transform.position += currentSpeed * transform.forward * Time.deltaTime;
            }
        }


        if (Input.GetKey(KeyCode.W) &! Input.GetKey(KeyCode.D) &! Input.GetKey(KeyCode.A))
        {
            if (transform.rotation.eulerAngles.y > ((180 + camRot + 360) % 360) && transform.rotation.eulerAngles.y < ((358 + camRot + 360) % 360))
            {
                transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y <= ((180 + camRot + 360) % 360) && transform.rotation.eulerAngles.y > ((2 + camRot + 360) % 360))
            {
                transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y < ((2 + camRot + 360) % 360))
            {
                transform.Rotate(Vector3.down, transform.rotation.eulerAngles.y + 360);
                //transform.Rotate(Vector3.up, (transform.rotation.eulerAngles.y + camRot + 360) % 360);
                transform.position += currentSpeed * cam.transform.forward * Time.deltaTime;
            }
            else
            {
                transform.Rotate(Vector3.up, (360 + camRot) % 360 - transform.rotation.eulerAngles.y);
            }
        }

        if (Input.GetKey(KeyCode.S) &! Input.GetKey(KeyCode.D) &! Input.GetKey(KeyCode.A))
        {
            if (transform.rotation.eulerAngles.y < ((178 + camRot + 360) % 360))
            {
                transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y > ((182 + camRot + 360) % 360))
            {
                transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.up, ((180 + camRot+ 360) % 360) - transform.rotation.eulerAngles.y);
                transform.position -= currentSpeed * cam.transform.forward * Time.deltaTime;
            }
        }

        if (Input.GetKey(KeyCode.A) &! Input.GetKey(KeyCode.W) &! Input.GetKey(KeyCode.S))
        {
            if (transform.rotation.eulerAngles.y > (272 + camRot) && transform.rotation.eulerAngles.y <= (90 + camRot))
            {
                transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y < (268 + camRot) && transform.rotation.eulerAngles.y > (90 + camRot))
            {
                transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            }
            else 
            {
                transform.Rotate(Vector3.up, (270 + camRot) - transform.rotation.eulerAngles.y);
                transform.position += currentSpeed * transform.forward * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.D) &! Input.GetKey(KeyCode.W) &! Input.GetKey(KeyCode.S))
        {
            if (transform.rotation.eulerAngles.y >= (270 + camRot) && transform.rotation.eulerAngles.y < (88 + camRot))
            {
                transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            }
            else if (transform.rotation.eulerAngles.y < (270 + camRot) && transform.rotation.eulerAngles.y > (92 + camRot + 360))
            {
                transform.Rotate(Vector3.down, turningSpeed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.up, (90 + camRot) - transform.rotation.eulerAngles.y);
                transform.position += currentSpeed * transform.forward * Time.deltaTime;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0f)
        {
            rb.AddExplosionForce(11000, transform.position + explosive, 5);
        }
    }

    public void addHealth(float health)
    {
        ratHealth += health;
        if (ratHealth > maxRatHealth)
        {
            ratHealth = maxRatHealth;
        }
    }
}
