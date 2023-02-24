using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    public GameObject CharacterObj;
    public GameObject ExitButton;
    public GameObject CharacterButton;
    public GameObject ScoreCoin;
    public GameObject Score;
    public GameObject MoveNumber;
    public GameObject BestTxt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SelectCharacter()
    {

        CharacterButton.SetActive(false);
        ScoreCoin.SetActive(false);
        Score.SetActive(false);
        ScoreCoin.SetActive(false);
        MoveNumber.SetActive(false);
        BestTxt.SetActive(false);

        CharacterObj.SetActive(true);
    }
}
