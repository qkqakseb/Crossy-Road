using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playSpeed = default;

    public GameObject playerMove;
    public bool isplayerMove = true;

    public Rigidbody PlayerRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // �÷��̾� ������
    public void Move()
    {
        // ������ ����Ű �Է�
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // 1ĭ�� ���� �ϱ� 
            PlayerRigidbody.position = new Vector3(transform.position.x - 1, 1, transform.position.z);
            //PlayerRigidbody.AddForce(-playSpeed, 1f, 0f);
            isplayerMove = true;
        }
        // �������� ����Ű �Է�
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            PlayerRigidbody.position = new Vector3(transform.position.x + 1, 1, transform.position.z);
            //PlayerRigidbody.AddForce(playSpeed, 1f, 0f);
            isplayerMove = true;
        }
        // ���� ����Ű �Է�
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            PlayerRigidbody.position = new Vector3(transform.position.x, 1, transform.position.z + 1);
            //PlayerRigidbody.AddForce(0f, 1f, playSpeed);
            isplayerMove = true;
        }
        // �Ʒ��� ����Ű �Է�
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            PlayerRigidbody.position = new Vector3(transform.position.x, 1, transform.position.z - 1);
            //PlayerRigidbody.AddForce(0f, 1f, -playSpeed);
            isplayerMove = true;
        }
        else
        {
            isplayerMove = false;
        }




    }
}
