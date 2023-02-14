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
        // �÷��̾��� ��ǥz�� 10�� �����϶� ���� Plane�� ��ġ�� 10�� �����̰� �Ѵ�.
        // Ư�� ��ġ�� �־���� Ȯ���� �� �ִ�.
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
