using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playSpeed = default;

    public GameObject StartBt;
    // private GameObject playerMove;
    public GameObject carmera;

    public bool isplayerMove = true;
    public bool isStopMove = false; // 터치 전 동작 멈춤
    public bool IsDie = false;


    // 코인 
    public GameObject Coin;
    public GameObject Score;
    int scoreCount;

    // 움직임 수
    public GameObject MoveNumber;
    public GameObject BestNumber;
    private string bestNumber;
    int moveCount;
    int bestCount;

    // Restart Ui
    public GameObject DBackground;
    public GameObject DGod;
    public GameObject DText;
    public GameObject RestartButton;



    public Vector3 startPos = default;
    private Rigidbody PlayerRigidbody;



    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
        startPos = transform.position;
        BestNumber.GetComponent<TMPro.TMP_Text>().text = PlayerPrefs.GetInt("bestNumber").ToString();
        bestCount = PlayerPrefs.GetInt("bestNumber");
    }

    // Update is called once per frame
    void Update()
    {
        isStopMove = StartBt.GetComponent<StartButton>().isStopMove;
        if (isStopMove == true)
        {
            Move();

            // 움직일때 MoveNumber 증가
            if (startPos.z + 1 <= transform.position.z)
            {
                // 초기화
                startPos = transform.position;
                // MoveNumber 가 1씩 증가
                moveCount++;
                MoveNumber.GetComponent<TextMesh>().text = moveCount.ToString();
            }

            // BestNumer 나타내기 (확인하기)
            if (moveCount > bestCount)
            {
                bestCount = moveCount;
                BestNumber.GetComponent<TMPro.TMP_Text>().text = bestCount.ToString();
                PlayerPrefs.SetInt("bestNumber", bestCount);

            }
        }
    }

    // �÷��̾� ������
    public void Move()
    {
        // ������ ����Ű �Է�
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // 1ĭ�� ���� �ϱ� 
            PlayerRigidbody.position = new Vector3(transform.position.x - 1, 2, transform.position.z);
            //Vector3 targetPos = new Vector3(transform.position.x - 1, 2, transform.position.z);
            //StartCoroutine(MoveToPos(targetPos));
            //PlayerRigidbody.AddForce(-playSpeed, 1f, 0f);
            isplayerMove = true;
        }
        // �������� ����Ű �Է�
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            PlayerRigidbody.position = new Vector3(transform.position.x + 1, 2, transform.position.z);
            //Vector3 targetPos = new Vector3(transform.position.x + 1, 2, transform.position.z);
            //StartCoroutine(MoveToPos(targetPos));
            //PlayerRigidbody.AddForce(playSpeed, 1f, 0f);
            isplayerMove = true;
        }
        // ���� ����Ű �Է�
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // 플레이어가 1씩 이동할때
            PlayerRigidbody.position = new Vector3(transform.position.x, 2, transform.position.z + 1);
            //Vector3 targetPos = new Vector3(transform.position.x, 2, transform.position.z + 1);
            //StartCoroutine(MoveToPos(targetPos));

            //PlayerRigidbody.AddForce(0f, 1f, playSpeed);
            isplayerMove = true;
        }
        // �Ʒ��� ����Ű �Է�
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            PlayerRigidbody.position = new Vector3(transform.position.x, 2, transform.position.z - 1);
            //Vector3 targetPos = new Vector3(transform.position.x, 2, transform.position.z - 1);
            //StartCoroutine(MoveToPos(targetPos));

            //PlayerRigidbody.AddForce(0f, 1f, -playSpeed);
            //isplayerMove = true;
        }
        else
        {
            isplayerMove = false;
        }

    }

    IEnumerator MoveToPos(Vector3 pos)
    {
        bool IsMoveComplete = false;
        while (!IsMoveComplete)
        {
            //transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime);
            PlayerRigidbody.position = Vector3.Lerp(transform.position, pos, playSpeed * Time.deltaTime);
            if (PlayerRigidbody.position == pos)
            {
                IsMoveComplete = true;
            }
            yield return null;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        // 코인인지 확인
        // tag가 coin이면 
        if (other.gameObject.tag == "coin")
        {
            // 비활성화하기
            other.gameObject.SetActive(false);
            // Score가 1씩 증가
            scoreCount++;
            Score.GetComponent<TextMesh>().text = scoreCount.ToString();
        }


        // 플레이어 죽었을때
        // 장애물에 닿았을때(나무 제외)
        if (other.gameObject.tag == "car")
        {

            // Restart 활성화
            DBackground.SetActive(true);
            DGod.SetActive(true);
            DText.SetActive(true);
            RestartButton.SetActive(true);
            gameObject.SetActive(false);
            IsDie = true;
        }
        if (other.gameObject.tag == "train")
        {
            // Restart 활성화
            DBackground.SetActive(true);
            DGod.SetActive(true);
            DText.SetActive(true);
            RestartButton.SetActive(true);
            gameObject.SetActive(false);

            IsDie = true;
        }
        if (other.gameObject.tag == "river")
        {
            // Restart 활성화
            DBackground.SetActive(true);
            DGod.SetActive(true);
            DText.SetActive(true);
            RestartButton.SetActive(true);
            gameObject.SetActive(false);

            IsDie = true;
        }
        if (other.gameObject.tag == "riverWave")
        {
            // Restart 활성화
            DBackground.SetActive(true);
            DGod.SetActive(true);
            DText.SetActive(true);
            RestartButton.SetActive(true);
            gameObject.SetActive(false);

            IsDie = true;
        }
        if (other.gameObject.tag == "tree")
        {

        }
    }




}
