using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right/speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right/speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward/speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward/speed;
        }
    }
}
