using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraAT : MonoBehaviour
{
    public GameObject Player; // ī�޶� ����ٴ�? Ÿ��

    public float offsetX = default;  // offset : Ÿ�����κ����� ī�޶� ��ġ
    public float offsetY = default;
    public float offsetZ = default;

    public float cameraSpeed = default; // ī�޶� �ӵ�

    Vector3 playerPos;  // Ÿ�� ��ġ

    private bool isplayerMove = default;  // �÷��̾��� ������ ����

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
            // ī�޶� ������ġ���� z�� -10 ��ġ���� ���� ���� �Ѵ�.(Inspetor���� ������)
            playerPos = new Vector3(Player.transform.position.x + offsetX, Player.transform.position.y + offsetY, Player.transform.position.z + offsetZ);

            // ī�޶��� �������� �ε巴�� �ϴ� �Լ�(Lerp)
            transform.position = Vector3.Lerp(transform.position, playerPos, Time.deltaTime * cameraSpeed * 10);


            //transform.position = playerPos;
            //Debug.Log($"player Pos : {playerPos} / CameraPos : {transform.position}");
        }
        else if (isplayerMove == false)
        {
            // ī�޶� ��ġ�� z������ +5 �Ǹ� ���߰� �Ѵ�
            if (playerPos.z + 5 <= transform.position.z)
            {
                //Debug.Log($"ī�޶� z��ġ : {transform.position.z} / �÷��̾� z��ġ : {playerPos.z}");
            }
            else
            {

                // ī�޶� ��ǥ z������ �����ֱ�
                Vector3 carmeraPos = new Vector3(playerPos.x, 0f, Time.deltaTime * (cameraSpeed * 0.02f));
                transform.position += carmeraPos;
                // ?��?���? ????�� ?��?��?��?�� 카메?�� 같이 ???직이�?
                transform.position = new Vector3(Player.transform.position.x, transform.position.y, transform.position.z);
                //Debug.Log(transform.position);
            }

        }

    }
}
