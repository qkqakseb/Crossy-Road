using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCubeMove : MonoBehaviour
{
    public float startTime;
    public float minX, maxX;
    public float moveSpeed;
    private float direction = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= startTime)
        {
            transform.position += new Vector3(moveSpeed * Time.deltaTime * direction, 0, 0);

            if (transform.position.x <= minX || transform.position.x >= maxX)
            {
                direction *= -1;
            }
        }
    }
    // 풀링으로 랜덤으로 나오게 하기
    // plane  따라 같이 움직이기
    // 큐브에 닿으면 멈춘다 (플레이어 죽는다.)
}
