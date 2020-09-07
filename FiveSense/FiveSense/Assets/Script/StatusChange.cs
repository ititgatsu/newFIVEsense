using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusChange : MonoBehaviour
{
    public GameObject status1;
    public GameObject status2;
    private float timeCount = 0;
    private int status  = 0;
    void Start()
    {
        
    }
    void Update()
    {
        timeCount++;
        if(timeCount % 300 == 0) 
        {
            status++;
        }
        if(status % 3 == 0) 
        {
            status1.SetActive(false);
            status2.SetActive(false);
        }
        else if(status % 3 == 1) 
        {
            status1.SetActive(true);
            status2.SetActive(false);
        }
        else if(status % 3 == 2) 
        {
            status1.SetActive(true);
            status2.SetActive(true);
        }
    }
}
