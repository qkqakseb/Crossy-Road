using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainRandom : MonoBehaviour
{
    public GameObject trainPrafeb;
    private GameObject instant;

    public GameObject findStopObj;

    int directionNum;
    int posCk;
    // Start is called before the first frame update
    void Start()
    {
        // ������ �濡 1���� �ʿ�
        // ���� ���� ���� ������
        // ��ȣ�Ⱑ ���� �ð����� ���� ������ 1�� �� ������ ���� ��������.

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
            // ��ȣ�� ������ �ð� ����
            yield return new WaitForSeconds(Random.Range(5, 20));
            // Debug.Log($"���� �ð�");
            // ��ȣ�� Ȱ��ȭ ��Ų��.
            findStopObj.SetActive(true);
            // Debug.Log($"Ȱ��ȭ : {findStopObj.activeSelf}");

            //1�� �ڿ� ������ (��Ȱ��)
            yield return new WaitForSeconds(2f);
            findStopObj.SetActive(false);
            // Debug.Log($"��Ȱ��ȭ : : {findStopObj.activeSelf}");

            // ���� �����δ�.
            instant = Instantiate(trainPrafeb, new Vector3(posCk, transform.position.y, transform.position.z), Quaternion.identity, transform);
            instant.GetComponent<TrainMove>().direction = directionNum;
            // Debug.Log($"�����̴� ����");
        }



        // yield return new WaitForSeconds(1f);

        // }

    }

}
