using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRandom : MonoBehaviour
{
    // HashSet<int> coinRandom = new HashSet<int>();
    public HashSet<int> coinRandom;
    private int coinCount;

    public GameObject coinPrafeb;
    private GameObject intstant;

    // Start is called before the first frame update
    void Start()
    {
        coinCount = Random.Range(0, 2);


        for (int i = 0; i < coinCount; i++)
        {
            int randNumber = Random.Range(-40, 40);
            // HashSet 가져오기
            coinRandom = GetComponent<TreeRandom>().treesRandom;

            if (coinRandom.Add(randNumber))
            {
                intstant = Instantiate(coinPrafeb, new Vector3(randNumber, 0.2f, transform.position.z), coinPrafeb.transform.rotation, transform);
            }
            else
            {
                i--;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
