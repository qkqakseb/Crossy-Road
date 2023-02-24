using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupWindow : MonoBehaviour
{
    [Space(5)]
    [Header("StartObj")]
    public GameObject StartButton;
    public GameObject Background;
    public GameObject ExitButton;
    public GameObject CharacterButton;
    public GameObject ScoreCoin;
    public GameObject Score;
    public GameObject MoveNumber;
    public GameObject BestTxt;

    [Space(5)]
    [Header("CharacterObj")]
    public GameObject Logo;
    public GameObject BackButton;
    public GameObject Reaper;
    public GameObject Ghost;
    public GameObject Ghost_1;
    public GameObject GirlGhost;
    public GameObject Skeleton;

    // Start is called before the first frame update
    void Start()
    {
        nextmainScene();

    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator NextMainScene()
    {
        yield return new WaitForSeconds(1f);
        Background.SetActive(false);

        StartButton.SetActive(true);
        ExitButton.SetActive(true);
        CharacterButton.SetActive(true);
        ScoreCoin.SetActive(true);
        Score.SetActive(true);
        ScoreCoin.SetActive(true);
        MoveNumber.SetActive(true);
        BestTxt.SetActive(true);

    }

    public void nextmainScene()
    {
        StartCoroutine(NextMainScene());
    }

    public void CharacterObj()
    {
        // nextmainscene 비활성화
        ExitButton.SetActive(false);
        CharacterButton.SetActive(false);
        MoveNumber.SetActive(false);
        BestTxt.SetActive(false);
        Logo.SetActive(false);

        // characterObj 활성화
        Background.SetActive(true);
        BackButton.SetActive(true);
        Reaper.SetActive(true);
        Ghost.SetActive(true);
        Ghost_1.SetActive(true);
        GirlGhost.SetActive(true);
        Skeleton.SetActive(true);
    }


    public void Back()
    {
        // characterObj 비활성
        Background.SetActive(false);
        BackButton.SetActive(false);
        Reaper.SetActive(false);
        Ghost.SetActive(false);
        Ghost_1.SetActive(false);
        GirlGhost.SetActive(false);
        Skeleton.SetActive(false);


        // StartObj 활성화
        Logo.SetActive(true);
        ExitButton.SetActive(true);
        CharacterButton.SetActive(true);
        ScoreCoin.SetActive(true);
        MoveNumber.SetActive(true);
        BestTxt.SetActive(true);
    }

}
