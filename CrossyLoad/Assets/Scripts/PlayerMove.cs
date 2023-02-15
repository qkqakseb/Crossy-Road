using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playSpeed = default;

    public GameObject playerMove;
    public bool isplayerMove = true;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // �÷��̾� �����̱�
    public void Move()
    {

        // �������� �����̱�
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-playSpeed * Time.deltaTime, 0, 0);// transform�� ������ ������
            isplayerMove = true;
        }
        // ���������� �����̱�
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(playSpeed * Time.deltaTime, 0, 0);
            isplayerMove = true;
        }
        // �������� �����̱�
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, playSpeed * Time.deltaTime);
            isplayerMove = true;
        }
        // �Ʒ������� �����̱�
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -playSpeed * Time.deltaTime);
            isplayerMove = true;
        }
        else
        {
            isplayerMove = false;
        }




    }
}
