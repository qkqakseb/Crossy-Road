using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomManager : MonoBehaviour
{
    public GameObject treeroad;
    public GameObject carroad;
    public GameObject logroad;
    public GameObject trainroad;
    //�������� �� 4���� �����.
    // switch ������ �����. 
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
        // ���� �÷��̾��� ��ġ�� ���� �Ÿ���ŭ �̵�������
        //switch(random 0~3)
        //0�� ������ �� : ���� ����
        //1�� ������ �� : �� ����
        //2�� ������ �� : ���� ����
        //3�� ������ �� : �볪�� ����


    }
}
