using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    void LateUpdate()
    {
        transform.position = target.position - target.forward * 15 + Vector3.up * 6;
        transform.LookAt(target);
    }
}