using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform verRot;
    public Transform horRot;
    void Start()
    {
        verRot = transform.parent;
        horRot = GetComponent<Transform>();
    }
    void FixedUpdate()
    {
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        verRot.transform.Rotate(0, X_Rotation * 4.0f, 0);
        horRot.transform.Rotate(-Y_Rotation, 0, 0);
    }
}
