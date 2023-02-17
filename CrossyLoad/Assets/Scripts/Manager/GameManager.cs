using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonBase<GameManager>
{
    public Stack<GameObject> CarPool;  // ��
    public Stack<GameObject> LogPool;  // �볪��
    public Stack<GameObject> TrainPool;  // ����

    public GameObject CarPrafeb;
    public GameObject LogPrafeb;
    public GameObject TrainPrafeb;

    public int carCount = default;
    public int logCount = default;
    public int TrainCount = default;

    public new void Awake()
    {
        base.Awake();

        // �ʱ�ȭ
        CarPool = new Stack<GameObject>();
        LogPool = new Stack<GameObject>();
        TrainPool = new Stack<GameObject>();

        //CarPoolCreate();
    }



    // �� Ǯ��
    public void CarPoolCreate()
    {

        Transform parent = GameObject.Find("Car").transform;

        for (int i = 0; i < carCount; i++)
        {
            // Debug.Log($"parent : {parent} / {parent.name} / {parent.GetInstanceID()}");
            GameObject CarObj = Instantiate(CarPrafeb, Vector3.zero, Quaternion.identity, parent);
            CarObj.SetActive(false);
            CarPool.Push(CarObj);
        }
    }
    public void CarPoolPush(GameObject CarObj)
    {
        CarPool.Push(CarObj);
    }
    public GameObject CarPoolPop()
    {
        if (CarPool.Count == 0) return null;
        return CarPool.Pop();
    }




    // �볪�� Ǯ��
    public void LoaPoolCreate()
    {
        for (int i = 0; i < logCount; i++)
        {
            GameObject LogObj = Instantiate(LogPrafeb, GameObject.Find("Log").transform);
            CarPool.Push(LogObj);
        }
    }
    public void LogPoolPush(GameObject LogObj)
    {
        CarPool.Push(LogObj);
    }
    public GameObject LogPoolPop()
    {
        if (LogPool.Count == 0) return null;
        return LogPool.Pop();
    }




    // ���� Ǯ��
    public void TrainPoolCreate()
    {
        for (int i = 0; i < TrainCount; i++)
        {
            GameObject TrainObj = Instantiate(LogPrafeb, GameObject.Find("Train").transform);
            CarPool.Push(TrainObj);
        }
    }
    public void TrainPoolPush(GameObject TrainObj)
    {
        CarPool.Push(TrainObj);
    }
    public GameObject TrainPoolPop()
    {
        if (TrainPool.Count == 0) return null;
        return TrainPool.Pop();
    }
}
