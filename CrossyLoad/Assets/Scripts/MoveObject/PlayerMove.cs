using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playSpeed = default;

    public GameObject StartBt;
    private GameObject playerMove;
    public bool isplayerMove = true;
    public bool isStopMove = false; // 터치 전 동작 멈춤

    // 코인 
    public GameObject Coin;
    public GameObject Score;
    int scoreCount;

    // 움직임 수
    public GameObject MoveNumber;
    int moveCount;


    private Rigidbody PlayerRigidbody;



    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        isStopMove = StartBt.GetComponent<StartButton>().isStopMove;
        if (isStopMove == true)
        {
            Move();
        }
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
            // 플레이어가 1씩 이동할때
            PlayerRigidbody.position = new Vector3(transform.position.x, 1, transform.position.z + 1);
            //PlayerRigidbody.AddForce(0f, 1f, playSpeed);

            // MoveNumber 가 1씩 증가
            moveCount++;
            MoveNumber.GetComponent<TextMesh>().text = moveCount.ToString();

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

    // 코인인지 확인
    public void OnTriggerEnter(Collider other)
    {
        // tag가 coin이면 
        if (other.gameObject.tag == "coin")
        {
            // 비활성화하기
            other.gameObject.SetActive(false);
            // Score가 1씩 증가
            scoreCount++;
            Score.GetComponent<TextMesh>().text = scoreCount.ToString();
        }
    }


}
