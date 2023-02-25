using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRandom : MonoBehaviour
{
    public int carCount;

    public GameObject carPrafeb;

    public GameObject Car1;
    public GameObject Car2;
    public GameObject Car3;

    public GameObject instant;

    int directionNum;
    int posCk;
    // Start is called before the first frame update
    void Start()
    {
        carCount = Random.Range(1, 5);
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

        StartCoroutine(createCar());
    }

    IEnumerator createCar()
    {
        for (int i = 0; i < carCount; i++)
        {
            carShapeRandom();
            instant = Instantiate(carPrafeb, new Vector3(posCk, 0.6f, transform.position.z), Quaternion.identity, transform);
            instant.GetComponent<CarMove>().direction = directionNum;

            yield return new WaitForSeconds(Random.Range(1, 5));

        }

    }

    public void carShapeRandom()
    {
        int carShape = Random.Range(0, 3);
        switch (carShape)
        {
            case 0:
                carPrafeb = Car1;
                break;
            case 1:
                carPrafeb = Car2;
                break;
            case 2:
                carPrafeb = Car3;
                break;
        }
    }
}
