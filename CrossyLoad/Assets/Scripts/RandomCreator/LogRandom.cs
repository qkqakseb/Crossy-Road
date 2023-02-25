using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogRandom : MonoBehaviour
{
    public int logCount;

    public GameObject logPrafeb;
    public GameObject instant;

    int directionNum;  // 방향 -1, 0 , 1 중 랜덤
    int posCk;  // 포지션이 -1이면, 1이면 판별 

    // Start is called before the first frame update
    void Start()
    {
        logCount = Random.Range(1, 6);
        directionNum = Random.Range(0, 2);

        if (directionNum == 0)
        {
            directionNum = -1;
        }

        posCk = directionNum;
        if (posCk == 1)
        {
            posCk = 40;
        }
        else
        {
            posCk = -40;
        }

        StartCoroutine(createLog());
    }

    IEnumerator createLog()
    {
        for (int i = 0; i < logCount; i++)
        {
            instant = Instantiate(logPrafeb, new Vector3(posCk, 0f, transform.position.z), Quaternion.identity, transform);
            instant.GetComponent<LogMove>().direction = directionNum;

            instant.transform.localScale = new Vector3(Random.Range(1.0f, 2.0f), 1f, 1f);

            yield return new WaitForSeconds(Random.Range(1, 4));

        }
    }
}
