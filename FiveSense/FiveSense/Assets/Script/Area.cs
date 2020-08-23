using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    public GameObject _player;
    private Vector3 pTrans;
    // Start is called before the first frame update
    void Start()
    {
        pTrans = this.gameObject.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y , _player.transform.position.z);
       // this.gameObject.transform.localScale = new Vector3(pTrans.x + Mathf.PingPong(Time.time, 5.0f), pTrans.y + Mathf.PingPong(Time.time, 5.0f), pTrans.z + Mathf.PingPong(Time.time, 5.0f));
    }
}
