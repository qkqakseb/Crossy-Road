using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainCameraAT : MonoBehaviour
{
    public GameObject Player; // ???? ??????? ???

    public float cameraSpeed = default; // ???? ???

    Vector3 playerPos;  // ??? ???

    private bool isplayerMove = default;  // ?÷?????? ?????? ????

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        isplayerMove = Player.GetComponent<PlayerMove>().isplayerMove;
        if (isplayerMove)
        {
            // ???? ??????????? z?? -10 ??????? ???? ???? ???.(Inspetor???? ??????)
            playerPos = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);

            // ?????? ???????? ?ε巴?? ??? ???(Lerp)
            transform.position = Vector3.Lerp(transform.position, playerPos, Time.deltaTime * cameraSpeed * 10);
        }
        else if (isplayerMove == false)
        {
            // ???? ????? z?????? +5 ??? ????? ???
            if (playerPos.z + 5 <= transform.position.z)
            {
                //Debug.Log($"???? z??? : {transform.position.z} / ?÷???? z??? : {playerPos.z}");
            }
            else
            {

                // ???? ??? z?????? ???????
                Vector3 carmeraPos = new Vector3(playerPos.x, 0f, Time.deltaTime * (cameraSpeed * 0.02f));
                transform.position += carmeraPos;
                // ???????? ?????? ???????????? 카메??? 같이 ???직이??
                transform.position = new Vector3(Player.transform.position.x, transform.position.y, transform.position.z);
            }

        }

    }



}
