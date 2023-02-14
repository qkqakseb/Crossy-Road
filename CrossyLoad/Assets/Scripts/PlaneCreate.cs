using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCreate : MonoBehaviour
{
    public GameObject player;

    public Vector3 startPos = default;

    // Start is called before the first frame update
    void Start()
    {
        startPos = player.transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        // 플레이어의 좌표z가 10씩 움직일때 마다 Plane의 위치도 10씩 움직이게 한다.
        // 특정 위치가 있어야지 확인할 수 있다.
        if (startPos.z + 10 <= player.transform.position.z)
        {
            startPos = player.transform.position;

            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z +10);

            Debug.Log(transform.position);
        }
        else if (startPos.z - 10 >= player.transform.position.z)
        {
            startPos = player.transform.position;

            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 10);
        }
    }
}
