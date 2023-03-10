using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainRandom : MonoBehaviour
{
    public int trainCount;

    public GameObject trainPrafeb;
    public GameObject instant;

    public GameObject findStopObj;

    int directionNum;
    int posCk;
    // Start is called before the first frame update
    void Start()
    {
        // 기차는 길에 1개만 필요
        // 기차 방향 랜덤 움직임
        // 신호기가 랜덤 시간으로 불이 켜지고 1초 뒤 꺼지면 기차 지나간다.

        directionNum = Random.Range(0, 2);

        if (directionNum == 0)
        {
            directionNum = -1;
        }

        posCk = directionNum;
        if (posCk == 1)
        {
            posCk = -20;
        }
        else
        {
            posCk = 20;
        }

        StartCoroutine(createTrain());
    }

    IEnumerator createTrain()
    {
        while (true)
        {
            // 신호기 켜지는 시간 랜덤
            yield return new WaitForSeconds(Random.Range(5, 20));
            Debug.Log($"랜덤 시간");
            // 신호기 활성화 시킨다.
            findStopObj.SetActive(true);
            Debug.Log($"활성화 : {findStopObj.activeSelf}");

            //1초 뒤에 꺼진다 (비활성)
            yield return new WaitForSeconds(2f);
            findStopObj.SetActive(false);
            Debug.Log($"비활성화 : : {findStopObj.activeSelf}");

            // 기차 움직인다.
            instant = Instantiate(trainPrafeb, new Vector3(posCk, transform.position.y, transform.position.z), Quaternion.identity, transform);
            instant.GetComponent<TrainMove>().direction = directionNum;
            Debug.Log($"움직이는 기차");
        }



        // yield return new WaitForSeconds(1f);

        // }

    }

}
