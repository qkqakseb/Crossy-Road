using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float minX, maxX;
    public float moveSpeed;
    public float direction = -1;


    // Start is called before the first frame update
    void Start()
    {
        if (direction == -1)
        {
            transform.rotation = Quaternion.Euler(0, -180, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(moveSpeed * direction * Time.deltaTime, 0f, 0f);
        if (transform.position.x <= minX - 1)
        {
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= maxX + 1)
        {
            transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }
    }
}
