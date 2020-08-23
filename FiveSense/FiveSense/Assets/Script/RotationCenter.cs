using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCenter : MonoBehaviour
{
    public Transform center;
    void Start()
    {
        center = GetComponent<Transform>();
    }
    void FixedUpdate()
    {
        float x_rotation = Input.GetAxis("Mouse X");
        center.transform.Rotate(0, 0, x_rotation * 4.0f);
    }
}
