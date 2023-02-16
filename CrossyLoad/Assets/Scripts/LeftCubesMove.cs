using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCubesMove : MonoBehaviour
{
    public float startTime;

    public float minX, maxX;

    public float moveSpeed;

    private float direction = -1;

    // Start is called before the first frame update
    Rigidbody logRigidbody;
    void Start()
    {
        logRigidbody = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // 통나무에 마찰을 주기위해 사용
        logRigidbody.velocity = new Vector3(5f * direction, 0f, 0f);
        if (transform.position.x <= minX || transform.position.x >= maxX)
        {
            logRigidbody.velocity = Vector3.zero;
            direction *= -1;
            logRigidbody.velocity = new Vector3(5f * direction, 0f, 0f);
        }

        if (Time.time >= startTime)
        {

            //transform.position += new Vector3(moveSpeed * Time.deltaTime * direction, 0, 0);

            // }
        }

        // Ǯ������ �������� ������ �ϱ�
        // plane  ���� ���� �����̱�
        // ť�꿡 ������ ����� (�÷��̾� �״´�.)
    }
}
