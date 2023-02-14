using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playSpeed = 5f;

    public GameObject playerMove;
    
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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-playSpeed * Time.deltaTime, 0, 0);// transform�� ������ ������
        }
        // ���������� �����̱�
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(playSpeed * Time.deltaTime, 0, 0);
        }
        // �������� �����̱�
        else if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(0, 0, playSpeed * Time.deltaTime);
        }
        // �Ʒ������� �����̱�
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -playSpeed * Time.deltaTime);
        }

    }
}
