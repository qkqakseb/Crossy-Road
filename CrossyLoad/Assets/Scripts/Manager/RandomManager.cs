using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomManager : MonoBehaviour
{
    public GameObject treeroad;
    public GameObject carroad;
    public GameObject riverroad;
    public GameObject trainroad;

    public Vector3 startPos = default;
    public GameObject Player = default;
    public GameObject RoadParent = default;
    public Queue<GameObject> roadsQueue = default;


    public bool isRoadCk;
    public int index = 0;


    //�������� �� 4���� �����.
    // switch ������ �����. 
    // Start is called before the first frame update
    void Start()
    {
        roadsQueue = new Queue<GameObject>();
        startPos = Player.transform.position;
        Player = GameObject.Find("Player");
        RoadParent = GameObject.Find("Roads");

        // treeraod�� 0~2���� ���� ����
        for (int i = 0; i < Random.Range(2, 4); i++)
        {
            // treeroad�� ����� ����
            roadsQueue.Enqueue(Instantiate(treeroad, new Vector3(0f, 0.1f, i + 1), Quaternion.identity, RoadParent.transform));
            index++;
        }

        for (int i = index; i <= 30; i++)
        {
            RandomCreate();
        }

    }

    // Update is called once per frame
    void Update()
    {
        // �÷��̾ z��ǥ�� 10ĭ ������
        if (startPos.z + 20 <= Player.transform.position.z && !isRoadCk)
        {
            isRoadCk = true;
        }

        // �÷��̾ ��ǥ z�� +3�� ������ ��
        if (startPos.z + 1 <= Player.transform.position.z && isRoadCk)
        {
            // Debug.Log($"�� �������");

            // startPos �ʱ�ȭ
            startPos = new Vector3(0f, 0f, Mathf.RoundToInt(Player.transform.position.z));

            // Debug.Log($"��ŸƮ ����");

            // �� ����
            RandomCreate();
            // �� ����
            Destroy(roadsQueue.Dequeue());
        }
    }

    public void RandomCreate()
    {
        int randNumber = Random.Range(0, 4);
        switch (randNumber)
        {
            case 0: // ������ �����(��ġ �˱�: ��� ��ġ���� ���� �����ǰ� ���� ��ǥ z)
                roadsQueue.Enqueue(Instantiate(treeroad, new Vector3(0f, 0.1f, index + 1), Quaternion.identity, RoadParent.transform));
                index++;
                // ���� x��ǥ�� ���� ����

                break;
            case 1:   // ���� �����
                roadsQueue.Enqueue(Instantiate(carroad, new Vector3(0f, 0.1f, index + 1), Quaternion.identity, RoadParent.transform));
                index++;
                break;
            case 2:  // �� �����
                roadsQueue.Enqueue(Instantiate(riverroad, new Vector3(0f, 0.1f, index + 1), Quaternion.identity, RoadParent.transform));
                index++;
                break;
            case 3:  // ������ �����
                roadsQueue.Enqueue(Instantiate(trainroad, new Vector3(0f, 0.1f, index + 1), Quaternion.identity, RoadParent.transform));
                index++;
                break;
            default:
                break;
        }
    }


}
