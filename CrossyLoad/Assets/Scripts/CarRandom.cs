using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRandom : MonoBehaviour
{
    public int carCount;

    public GameObject carPrafeb;
    public GameObject instant;

    int directionNum;
    int posCk;
    // Start is called before the first frame update
    void Start()
    {
        carCount = Random.Range(1, 10);
        directionNum = Random.Range(0, 2);

        if (directionNum == 0)
        {
            directionNum = -1;
        }

        posCk = directionNum;
        if (posCk == 1)
        {
            posCk = 20;
        }
        else
        {
            posCk = -20;
        }

        StartCoroutine(createCar());
    }

    IEnumerator createCar()
    {
        for (int i = 0; i < carCount; i++)
        {
            instant = Instantiate(carPrafeb, new Vector3(posCk, 0.5f, transform.position.z), Quaternion.identity, transform);
            instant.GetComponent<CarMove>().direction = directionNum;
            // Debug.Log(posCk);
            // Debug.Log($"transform POsition : {transform.position}");

            yield return new WaitForSeconds(Random.Range(1, 5));

        }

    }

    // // Update is called once per frame
    // void Update()
    // {

    // }
}
