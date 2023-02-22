using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeRandom : MonoBehaviour
{
    HashSet<int> treesRandom = new HashSet<int>();
    public int treeCount;

    public GameObject treePrafeb;


    public GameObject oneTree;
    public GameObject twoTree;
    public GameObject threeTree;

    // Instaiat ��� ����
    public GameObject instant;

    // Start is called before the first frame update
    void Start()
    {
        // ������ ���� 1~10�� �������� �����
        treeCount = Random.Range(1, 10);

        // �������� ������ x��ǥ�� ���� �����
        for (int i = 0; i < treeCount; i++)
        {
            int randNumber = Random.Range(-50, 13);
            if (treesRandom.Add(randNumber))
            {
                treeShpeRandom();
                instant = Instantiate(treePrafeb, new Vector3(randNumber, 0.6f, transform.position.z), Quaternion.identity, transform);
                // Debug.Log($"���� ��� : {treePrafeb}");
            }
            else
            {
                i--;
            }
        }
    }

    public void treeShpeRandom()
    {
        // 3���� ������ �������� ������ �ϱ�
        int treeShape = Random.Range(0, 3);
        switch (treeShape)
        {
            case 0:
                treePrafeb = oneTree;
                break;
            case 1:
                treePrafeb = twoTree;
                break;
            case 2:
                treePrafeb = threeTree;
                break;
        }
    }
}
