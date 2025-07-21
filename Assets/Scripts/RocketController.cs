using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RocketController : MonoBehaviour
{
    public ParticleSystem burn;
    public Slider thrustSlider;
    public float thrustForce = 9.8f;
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
            if (!burn.isPlaying)
                burn.Play();

            rb.AddForce(transform.up * thrustSlider.value * thrustForce);
        }
        else
        {
            if (burn.isPlaying)
                burn.Stop();
        }

        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    }

    void FixedUpdate()
    {
        // Simulated Gravity
    }
}
