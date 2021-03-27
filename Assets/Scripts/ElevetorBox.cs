using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevetorBox : MonoBehaviour
{
    private Rigidbody rigid;
    private Vector3 defaultPos;

    public int ElevetorHigh;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        defaultPos = transform.position;
    }

    void FixedUpdate()
    {
        rigid.MovePosition(new Vector3(defaultPos.x, defaultPos.y + Mathf.PingPong(Time.time, ElevetorHigh), defaultPos.z));
    }
}
