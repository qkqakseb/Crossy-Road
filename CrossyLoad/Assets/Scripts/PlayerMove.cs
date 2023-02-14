using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playSpeed = 5f;

    public GameObject playerMove;
    
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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-playSpeed * Time.deltaTime, 0, 0);// transform은 움직임 딱딱함
        }
        // 오른쪽으로 움직이기
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(playSpeed * Time.deltaTime, 0, 0);
        }
        // 위쪽으로 움직이기
        else if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(0, 0, playSpeed * Time.deltaTime);
        }
        // 아래쪽으로 움직이기
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -playSpeed * Time.deltaTime);
        }

    }
}
