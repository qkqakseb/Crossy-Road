using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeRandom : MonoBehaviour
{
    HashSet<int> treesRandom = new HashSet<int>();
    public int treeCount;

    public GameObject treePrafeb;

    // Instaiat 담기 위해
    public GameObject instant;

    // Start is called before the first frame update
    void Start()
    {
        treeCount = Random.Range(1, 10);
        // 나무길의 랜덤한 x좌표에 나무 만들기
        for (int i = 0; i < treeCount; i++)
        {
            int randNumber = Random.Range(-20, 20);
            if (treesRandom.Add(randNumber))
            {
                // Debug.Log(transform.position);
                instant = Instantiate(treePrafeb, new Vector3(randNumber, transform.position.y, transform.position.z), Quaternion.identity, transform);
                // Debug.Log($"나무 위치 : {instant.transform.position}");
            }
            else
            {
                i--;
            }
        }
    }

    // // Update is called once per frame
    // void Update()
    // {

    // }
}
