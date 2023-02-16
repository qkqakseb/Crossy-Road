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

        for (int i = index; i <= 30; i++)
        {
            RandomCreate();
        }

    }

    // Update is called once per frame
    void Update()
    {
        // 플레이어가 z좌표로 10칸 갔을때
        if (startPos.z + 20 <= Player.transform.position.z && !isRoadCk)
        {
            isRoadCk = true;
        }

        // 플레이어가 좌표 z로 +3씩 움직일 때
        if (startPos.z + 1 <= Player.transform.position.z && isRoadCk)
        {
            // Debug.Log($"길 만들어짐");

            // startPos 초기화
            startPos = new Vector3(0f, 0f, Mathf.RoundToInt(Player.transform.position.z));

            // Debug.Log($"스타트 포스");

            // 길 생성
            RandomCreate();
            // 길 제거
            Destroy(roadsQueue.Dequeue());
        }
    }

    public void RandomCreate()
    {
        int randNumber = Random.Range(0, 4);
        switch (randNumber)
        {
            case 0: // 나무길 만들기(위치 알기: 어디 위치에서 부터 생성되게 할지 좌표 z)
                roadsQueue.Enqueue(Instantiate(treeroad, new Vector3(0f, 0.1f, index + 1), Quaternion.identity, RoadParent.transform));
                index++;
                // 나무 x좌표에 랜덤 생성

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
    }


}
