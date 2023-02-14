using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraAT : MonoBehaviour
{
    public GameObject Player; // 카메라가 따라다닐 타겟

    public float offsetX = default;  // offset : 타켓으로부터의 카메라 위치
    public float offsetY = default;
    public float offsetZ = default;

    public float cameraSpeed = 10f;
    Vector3 playerPos;  // 타겟 위치

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = new Vector3(Player.transform.position.x + offsetX, Player.transform.position.y + offsetY, Player.transform.position.z + offsetZ);
        
        // 카메라의 움직임을 부드럽게 하는 함수(Lerp)
        transform.position = Vector3.Lerp(transform.position, playerPos, Time.deltaTime * cameraSpeed);
    }
}
