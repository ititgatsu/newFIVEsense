using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookEnemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public GameObject a1_1;
    public GameObject a1_2;
    public GameObject a1_3;
    public GameObject a2_1;
    public GameObject a2_2;
    public GameObject a2_3;
    public GameObject a3_1;
    public GameObject a3_2;
    public GameObject a3_3;
    public GameObject a4_1;
    public GameObject a4_2;
    public GameObject a4_3;
    public GameObject a5_1;
    public GameObject a5_2;
    public GameObject a5_3;
    public GameObject a6_1;
    public GameObject a6_2;
    public GameObject a6_3;
    public GameObject a7_1;
    public GameObject a7_2;
    public GameObject a7_3;
    public GameObject a8_1;
    public GameObject a8_2;
    public GameObject a8_3;
    private Quaternion quaternion;
    private Quaternion playerQua;
    private Vector3 vector;
    private float distance;
    private float distanceX;
    private float distanceZ;
    public float distanceFirst, distanceSecond;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        transform.position = player.transform.position;
        transform.LookAt(enemy.transform);
        quaternion = this.transform.rotation;
        vector = quaternion.eulerAngles;
        distanceX = enemy.transform.position.x - transform.position.x;
        distanceZ = enemy.transform.position.z - transform.position.z;
        distance = Mathf.Sqrt(distanceX * distanceX + distanceZ * distanceZ);
        if ((vector.y >= 337.5f && vector.y <= 360.0f) || (vector.y < 22.5f && vector.y >= 0.0f))
        {
            a1_1.SetActive(true);
            if (distance < distanceSecond)
            {
                a1_2.SetActive(true);
                if (distance < distanceFirst)
                {
                    a1_3.SetActive(true);
                }
                else
                {
                    a1_3.SetActive(false);
                }
            }
            else
            {
                a1_2.SetActive(false);
            }
        }
        else
        {
            a1_1.SetActive(false);
            a1_2.SetActive(false);
            a1_3.SetActive(false);
        }
        if (vector.y >= 22.5f && vector.y < 67.5f)
        {
            a2_1.SetActive(true);
            if (distance < distanceSecond)
            {
                a2_2.SetActive(true);
                if (distance < distanceFirst)
                {
                    a2_3.SetActive(true);
                }
                else
                {
                    a2_3.SetActive(false);
                }
            }
            else
            {
                a2_2.SetActive(false);
            }
        }
        else
        {
            a2_1.SetActive(false);
            a2_2.SetActive(false);
            a2_3.SetActive(false);
        }
        if (vector.y >= 67.5f && vector.y < 112.5f)
        {
            a3_1.SetActive(true);
            if (distance < distanceSecond)
            {
                a3_2.SetActive(true);
                if (distance < distanceFirst)
                {
                    a3_3.SetActive(true);
                }
                else
                {
                    a3_3.SetActive(false);
                }
            }
            else
            {
                a3_2.SetActive(false);
            }
        }
        else
        {
            a3_1.SetActive(false);
            a3_2.SetActive(false);
            a3_3.SetActive(false);
        }
        if (vector.y >= 112.5f && vector.y < 157.5f)
        {
            a4_1.SetActive(true);
            if (distance < distanceSecond)
            {
                a4_2.SetActive(true);
                if (distance < distanceFirst)
                {
                    a4_3.SetActive(true);
                }
                else
                {
                    a4_3.SetActive(false);
                }
            }
            else
            {
                a4_2.SetActive(false);
            }
        }
        else
        {
            a4_1.SetActive(false);
            a4_2.SetActive(false);
            a4_3.SetActive(false);
        }
        if (vector.y >= 157.5f && vector.y < 202.5f)
        {
            a5_1.SetActive(true);
            if (distance < distanceSecond)
            {
                a5_2.SetActive(true);
                if (distance < distanceFirst)
                {
                    a5_3.SetActive(true);
                }
                else
                {
                    a5_3.SetActive(false);
                }
            }
            else
            {
                a5_2.SetActive(false);
            }
        }
        else
        {
            a5_1.SetActive(false);
            a5_2.SetActive(false);
            a5_3.SetActive(false);
        }
        if (vector.y >= 202.5f && vector.y < 247.5f)
        {
            a6_1.SetActive(true);
            if (distance < distanceSecond)
            {
                a6_2.SetActive(true);
                if (distance < distanceFirst)
                {
                    a6_3.SetActive(true);
                }
                else
                {
                    a6_3.SetActive(false);
                }
            }
            else
            {
                a6_2.SetActive(false);
            }
        }
        else
        {
            a6_1.SetActive(false);
            a6_2.SetActive(false);
            a6_3.SetActive(false);
        }
        if (vector.y >= 247.5f && vector.y < 292.5f)
        {
            a7_1.SetActive(true);
            if (distance < distanceSecond)
            {
                a7_2.SetActive(true);
                if (distance < distanceFirst)
                {
                    a7_3.SetActive(true);
                }
                else
                {
                    a7_3.SetActive(false);
                }
            }
            else
            {
                a7_2.SetActive(false);
            }
        }
        else
        {
            a7_1.SetActive(false);
            a7_2.SetActive(false);
            a7_3.SetActive(false);
        }
        if (vector.y >= 292.5f && vector.y < 337.5f)
        {
            a8_1.SetActive(true);
            if (distance < distanceSecond)
            {
                a8_2.SetActive(true);
                if (distance < distanceFirst)
                {
                    a8_3.SetActive(true);
                }
                else
                {
                    a8_3.SetActive(false);
                }
            }
            else
            {
                a8_2.SetActive(false);
            }
        }
        else
        {
            a8_1.SetActive(false);
            a8_2.SetActive(false);
            a8_3.SetActive(false);
        }
    }
}

