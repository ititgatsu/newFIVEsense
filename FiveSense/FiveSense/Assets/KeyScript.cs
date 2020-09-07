using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public bool HavingKey;
    public int DoorCount;
    // Start is called before the first frame update
    void Start()
    {
        HavingKey = false;
        DoorCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key"&&HavingKey==false)
        {
            HavingKey = true;
            Destroy(other.gameObject);
        }
        if (other.tag == "Door"&&HavingKey==true)
        {
            HavingKey = false;
            DoorCount += 1;
            if (DoorCount >= 4)
            {
                Destroy(other.gameObject);
            }
        }
    }
}
