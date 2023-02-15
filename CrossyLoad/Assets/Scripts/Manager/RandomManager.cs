using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomManager : MonoBehaviour
{
    public GameObject treeroad;
    public GameObject carroad;
    public GameObject logroad;
    public GameObject trainroad;
    //랜덤으로 길 4개를 만든다.
    // switch 문으로 만든다. 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int randNumber = Random.Range(0, 4);
        switch (randNumber)
        {
            case 0: 

                break;
            case 1: 
                break;
            case 2: 
                break;
            case 3: 
                break;
            default:
                break;
        }
        //
        // 만약 플레이어의 위치가 일정 거리만큼 이동했으면
        //switch(random 0~3)
        //0이 나왔을 때 : 나무 만듬
        //1이 나왔을 때 : 차 만듬
        //2가 나왔을 떄 : 기차 만듬
        //3이 나왔을 때 : 통나무 만듬


    }
}
