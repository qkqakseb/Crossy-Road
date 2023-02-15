using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraAT : MonoBehaviour
{
    public GameObject Player; // 카메라가 따라다닐 타겟

    public float offsetX = default;  // offset : 타켓으로부터의 카메라 위치
    public float offsetY = default;
    public float offsetZ = default;

    public float cameraSpeed = default; // 카메라 속도

    Vector3 playerPos;  // 타겟 위치

    private bool isplayerMove = default;  // 플레이어의 움직임 유무

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
            // 카메라가 유저위치보다 z가 -10 위치에서 따라 오게 한다.(Inspetor에서 조절함)
            playerPos = new Vector3(Player.transform.position.x + offsetX, Player.transform.position.y + offsetY, Player.transform.position.z+offsetZ);

            // 카메라의 움직임을 부드럽게 하는 함수(Lerp)
            transform.position = Vector3.Lerp(transform.position, playerPos, Time.deltaTime * cameraSpeed*10);


            //transform.position = playerPos;
            //Debug.Log($"player Pos : {playerPos} / CameraPos : {transform.position}");
        }
        else if (isplayerMove == false)
        {
            // 카메라 위치기 z축으로 +5 되면 멈추게 한다
            if (playerPos.z + 5 <= transform.position.z)
            {
                //Debug.Log($"카메라 z위치 : {transform.position.z} / 플레이어 z위치 : {playerPos.z}");
            }
            else
            {

                // 카메라가 좌표 z축으로 가속주기
                Vector3 carmeraPos = new Vector3(0f, 0f, Time.deltaTime * (cameraSpeed * 0.02f));
                transform.position += carmeraPos;
                //Debug.Log(transform.position);
            }

        }
        
    }
}
