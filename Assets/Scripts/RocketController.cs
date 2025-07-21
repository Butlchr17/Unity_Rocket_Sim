using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RocketController : MonoBehaviour
{
    public ParticleSystem burn;
    public Slider thrustSlider;
    public Text statusText;
    public float thrustForce = 9.8f;
    public float pitch = 0f;
    public float rotationSpeed = 0.25f;
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


        pitch = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            pitch = rotationSpeed * Time.deltaTime; // Tilt forward
        }
        else if (Input.GetKey(KeyCode.S))
        {
            pitch = -rotationSpeed * Time.deltaTime;  // Tilt backward
        }

        // Yaw with A/D or arrows
        float yaw = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        // Apply rotation
        transform.Rotate(pitch, yaw, 0f);

        statusText.text = $"PosX: {transform.position.x:F2} m, PosY: {transform.position.y:F2} m, PosZ: {transform.position.z:F2}m\n"
                          + $"VelX: { rb.velocity.x:F2} m/s, VelY: { rb.velocity.y:F2} m/s, VelZ: { rb.velocity.z:F2} m/s";
    }

    void FixedUpdate()
    {
        // Simulated Gravity
    }

}
