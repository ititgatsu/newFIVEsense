using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syokusyu : MonoBehaviour
{
    private Vector3 myScale;
    // Start is called before the first frame update
    void Start()
    {
        myScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(myScale.x + Mathf.PingPong(Time.time, 10.0f), myScale.y, myScale.z);
    }
}
