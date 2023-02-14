using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraAT : MonoBehaviour
{
    public GameObject Player; // ī�޶� ����ٴ� Ÿ��

    public float offsetX = default;  // offset : Ÿ�����κ����� ī�޶� ��ġ
    public float offsetY = default;
    public float offsetZ = default;

    public float cameraSpeed = 10f;
    Vector3 playerPos;  // Ÿ�� ��ġ

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = new Vector3(Player.transform.position.x + offsetX, Player.transform.position.y + offsetY, Player.transform.position.z + offsetZ);
        
        // ī�޶��� �������� �ε巴�� �ϴ� �Լ�(Lerp)
        transform.position = Vector3.Lerp(transform.position, playerPos, Time.deltaTime * cameraSpeed);
    }
}
