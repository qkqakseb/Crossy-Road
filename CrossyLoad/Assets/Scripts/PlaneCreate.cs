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
        // Ư�� ��ġ�� �־���� Ȯ���� �� �ִ�.
        startPos = player.transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        // �÷��̾��� ��ǥz�� 10�� �����϶� ���� Plane�� ��ġ�� 10�� �����̰� �Ѵ�.
        // ������ ����
        if (startPos.z + 5 <= player.transform.position.z)
        {
            startPos = player.transform.position;

            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z +5);

            //Debug.Log(transform.position);
        }
        // �ڷ� ����
        else if (startPos.z - 5 >= player.transform.position.z)
        {
            startPos = player.transform.position;

            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 5);
        }
    }
}
