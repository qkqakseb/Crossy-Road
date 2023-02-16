using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playSpeed = default;

    public GameObject playerMove;
    public bool isplayerMove = true;

    public Rigidbody PlayerRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // 플레이어 움직임
    public void Move()
    {
        // 왼쪽의 방향키 입력
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // 1칸씩 가게 하기 
            PlayerRigidbody.position = new Vector3(transform.position.x - 1, 1, transform.position.z);
            //PlayerRigidbody.AddForce(-playSpeed, 1f, 0f);
            isplayerMove = true;
        }
        // 오른쪽의 방향키 입력
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            PlayerRigidbody.position = new Vector3(transform.position.x + 1, 1, transform.position.z);
            //PlayerRigidbody.AddForce(playSpeed, 1f, 0f);
            isplayerMove = true;
        }
        // 위의 방향키 입력
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            PlayerRigidbody.position = new Vector3(transform.position.x, 1, transform.position.z + 1);
            //PlayerRigidbody.AddForce(0f, 1f, playSpeed);
            isplayerMove = true;
        }
        // 아래의 방향키 입력
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
}
