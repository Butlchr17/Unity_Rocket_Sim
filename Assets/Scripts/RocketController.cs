using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{

    public float thrustForce = 10f;
    public float rotationSpeed = 100f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.up * thrustForce);
        }


        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    }


    void FixedUpdate()
    {
        // Simulated Gravity
    }
}
