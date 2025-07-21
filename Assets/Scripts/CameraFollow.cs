using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    void LateUpdate()
    {
        transform.position = target.position - target.forward * 5 + Vector3.up * 2;
        transform.LookAt(target);
    }
}
