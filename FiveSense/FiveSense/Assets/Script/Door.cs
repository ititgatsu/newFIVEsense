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
    private bool isClose = false;
    void Start()
    {
        
    }
    void Update()
    {
        if(isOpen == true)
        {
            door.transform.Translate(moveX, moveY, moveZ);
            Invoke("StopDoor", 1);
        }
        if(isClose == true) 
        {
            door.transform.Translate(-moveX, -moveY, -moveZ);
            Invoke("StopDoorSecond", 1);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isOpen = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            isClose = true;
        }
    }
    void StopDoor()
    {
        isOpen = false;
    }
    void StopDoorSecond() 
    {
        isClose = false;
    }
}
