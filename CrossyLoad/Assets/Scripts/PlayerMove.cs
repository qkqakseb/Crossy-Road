using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playSpeed = default;

    public GameObject playerMove;
    public bool isplayerMove = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    // 플레이어 움직이기
    public void Move()
    {

        // 왼쪽으로 움직이기
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-playSpeed * Time.deltaTime, 0, 0);// transform은 움직임 딱딱함
            isplayerMove = true;
        }
        // 오른쪽으로 움직이기
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(playSpeed * Time.deltaTime, 0, 0);
            isplayerMove = true;
        }
        // 위쪽으로 움직이기
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, playSpeed * Time.deltaTime);
            isplayerMove = true;
        }
        // 아래쪽으로 움직이기
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -playSpeed * Time.deltaTime);
            isplayerMove = true;
        }
        else
        {
            isplayerMove = false;
        }




    }
}
