using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;
    public float moveX;
    public float moveY;
    public float moveZ;
    private bool isOpen = false;
    private bool isFirst = true;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        if(isOpen == true)
        {
            door.transform.Translate(moveX, moveY, moveZ);
            Invoke("StopDoor", 3);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && isFirst == true)
        {
            isOpen = true;
            isFirst = false;
        }
    }
    void StopDoor()
    {
        isOpen = false;
    }
}
