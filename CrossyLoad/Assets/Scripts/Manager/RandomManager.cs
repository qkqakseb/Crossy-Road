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

    public int index = 0;


    //랜덤으로 길 4개를 만든다.
    // switch 문으로 만든다. 
    // Start is called before the first frame update
    void Start()
    {
        roadsQueue = new Queue<GameObject>();
        startPos = Player.transform.position;
        Player = GameObject.Find("Player");
        RoadParent = GameObject.Find("Roads");

        // treeraod를 0~2까지 랜덤 생성
        for (int i = 0; i < Random.Range(2, 4); i++)
        {
            // treeroad가 만들어 진다
            roadsQueue.Enqueue(Instantiate(treeroad, new Vector3(0f, 0.1f, i + 1), Quaternion.identity, RoadParent.transform));
            index++;
        }

        for (int i = index; i <= 10; i++)
        {
            RandomCreate();
        }

    }

    // Update is called once per frame
    void Update()
    {
        // 플레이어가 좌표 z로 +10씩 움직일 때
        if (startPos.z + 3 <= Player.transform.position.z)
        {
            // startPos 초기화
            startPos = new Vector3(0f, 0f, Mathf.RoundToInt(Player.transform.position.z));
            // Debug.Log($"스타트 포스");
            for (int i = 0; i < 10; i++)
            {
                RandomCreate();
            }
            // 큐에 넣은것 차례대로 지운다.
            Destroy(roadsQueue.Dequeue());
        }

    }

    public void RandomCreate()
    {
        // Debug.Log($"플레이어 좌표 움직임");
        int randNumber = Random.Range(0, 4);
        switch (randNumber)
        {
            case 0: // 나무길 만들기(위치 알기: 어디 위치에서 부터 생성되게 할지 좌표 z)
                    // treeroad 랜덤
                roadsQueue.Enqueue(Instantiate(treeroad, new Vector3(0f, 0.1f, index + 1), Quaternion.identity, RoadParent.transform));
                index++;
                break;
            case 1:   // 도로 만들기
                roadsQueue.Enqueue(Instantiate(carroad, new Vector3(0f, 0.1f, index + 1), Quaternion.identity, RoadParent.transform));
                index++;
                break;
            case 2:  // 강 만들기
                roadsQueue.Enqueue(Instantiate(riverroad, new Vector3(0f, 0.1f, index + 1), Quaternion.identity, RoadParent.transform));
                index++;
                break;
            case 3:  // 기차길 만들기
                roadsQueue.Enqueue(Instantiate(trainroad, new Vector3(0f, 0.1f, index + 1), Quaternion.identity, RoadParent.transform));
                index++;
                break;
            default:
                break;
        }
        


        //Destroy();
    }
}
