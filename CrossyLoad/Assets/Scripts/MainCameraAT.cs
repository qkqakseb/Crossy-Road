using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainCameraAT : MonoBehaviour
{
    public GameObject Player; // ???? ??????? ???
    public GameObject StartBt;
    public GameObject DieGod;

    // Restart Ui
    public GameObject DBackground;
    public GameObject DGod;
    public GameObject DText;
    public GameObject RestartButton;

    public float cameraSpeed = default; // ???? ???
    public float godSpeed = default;


    public Vector3 playerPos;  // ??? ???
    public Vector3 carmeraPos;

    private bool isplayerMove = default;  // ????????? ?????? ????
    public bool isStopMove = false; // ??? ?? ???? ???? 


    public bool isDieGod = default;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        isStopMove = StartBt.GetComponent<StartButton>().isStopMove;

        if (isStopMove == true)
        {
            isplayerMove = Player.GetComponent<PlayerMove>().isplayerMove;
            if (isplayerMove)
            {
                // ???? ??????????? z?? -10 ??????? ???? ???? ???.(Inspetor???? ??????)
                playerPos = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);

                // ?????? ???????? ??????? ??? ???(Lerp)
                transform.position = Vector3.Lerp(transform.position, playerPos, Time.deltaTime * cameraSpeed * 10);
            }
            else if (isplayerMove == false)
            {
                // ???? ????? z?????? +5 ??? ????? ???
                if (playerPos.z + 5 <= transform.position.z)
                {
                    if (!isDieGod)
                    {
                        isDieGod = true;
                        DieGod.transform.position = new Vector3(transform.position.x, 12f, Player.transform.position.z + 10);
                        // �ϵ����� ��Ÿ����
                        DieGod.SetActive(true);

                        StartCoroutine(playerDely());

                    }
                    // ���ư���
                    Vector3 dieGod = new Vector3(0f, 0f, -(Time.deltaTime * godSpeed));
                    DieGod.transform.position += dieGod;
                }
                else
                {
                    if (!Player.GetComponent<PlayerMove>().IsDie)
                    {
                        // ???? ??? z?????? ???????
                        Vector3 carmeraPos = new Vector3(playerPos.x, 0f, Time.deltaTime * (cameraSpeed * 0.02f));
                        transform.position += carmeraPos;
                        // ???????? ?????? ???????????? ?????? ???? ?????????
                        transform.position = new Vector3(Player.transform.position.x, transform.position.y, transform.position.z);
                    }
                }

            }

        }
    }

    IEnumerator playerDely()
    {
        yield return new WaitForSeconds(0.6f);
        // �÷��̾� ��Ȱ��
        Player.SetActive(false);

        yield return new WaitForSeconds(0.6f);
        // Restart 활성화
        DBackground.SetActive(true);
        DGod.SetActive(true);
        DText.SetActive(true);
        RestartButton.SetActive(true);

    }



}
