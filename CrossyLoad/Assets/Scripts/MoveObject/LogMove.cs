using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LogMove : MonoBehaviour
{
    public float minX, maxX;
    public float moveSpeed;
    public float direction = -1;
    Rigidbody logRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        logRigidbody = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // �볪���� ������ �ֱ����� ���
        logRigidbody.velocity = new Vector3(moveSpeed * direction, 0f, 0f);
        if (transform.position.x <= minX - 1)
        {
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= maxX + 1)
        {
            transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }



    }
}
