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
    [Header("CharacterUi")]
    public GameObject Logo;
    public GameObject BackButton;
    public GameObject ReaperUi;
    public GameObject GhostUi;
    public GameObject Ghost_1Ui;
    public GameObject GirlGhostUi;
    public GameObject SkeletonUi;

    [Space(5)]
    [Header("CharacterImage")]
    public GameObject ReaperImage;
    public GameObject GhostImage;
    public GameObject Ghost_1Image;
    public GameObject GirlGhostImage;
    public GameObject SkeletonImage;

    [Space(5)]
    [Header("Character")]
    public GameObject Reaper;
    public GameObject Ghost;
    public GameObject Ghost_1;
    public GameObject GirlGhost;
    public GameObject Skeleton;

    [Space(5)]
    [Header("Restart")]
    public GameObject DBackground;
    public GameObject DGod;
    public GameObject DText;
    public GameObject RestartButton;
    public GameObject Player;
    public GameObject Carmara;

    // Start is called before the first frame update
    void Start()
    {
        nextmainScene();
        //BestTxt
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
        ReaperUi.SetActive(true);
        GhostUi.SetActive(true);
        Ghost_1Ui.SetActive(true);
        GirlGhostUi.SetActive(true);
        SkeletonUi.SetActive(true);
    }


    public void Back()
    {
        // characterObj 비활성
        Background.SetActive(false);
        BackButton.SetActive(false);
        ReaperUi.SetActive(false);
        GhostUi.SetActive(false);
        Ghost_1Ui.SetActive(false);
        GirlGhostUi.SetActive(false);
        SkeletonUi.SetActive(false);


        // StartObj 활성화
        Logo.SetActive(true);
        ExitButton.SetActive(true);
        CharacterButton.SetActive(true);
        ScoreCoin.SetActive(true);
        MoveNumber.SetActive(true);
        BestTxt.SetActive(true);
    }

    public void SelectCharacter(string SelectName)
    {
        switch (SelectName)
        {
            case "ReaperUi":
                ReaperImage.SetActive(true);
                Reaper.SetActive(true);
                GhostImage.SetActive(false);
                Ghost.SetActive(false);
                Ghost_1Image.SetActive(false);
                Ghost_1.SetActive(false);
                GirlGhostImage.SetActive(false);
                GirlGhost.SetActive(false);
                SkeletonImage.SetActive(false);
                Skeleton.SetActive(false);
                break;

            case "GhostUi":
                GhostImage.SetActive(true);
                Ghost.SetActive(true);
                ReaperImage.SetActive(false);
                Reaper.SetActive(false);
                Ghost_1Image.SetActive(false);
                Ghost_1.SetActive(false);
                GirlGhostImage.SetActive(false);
                GirlGhost.SetActive(false);
                SkeletonImage.SetActive(false);
                Skeleton.SetActive(false);
                break;

            case "Ghost_1Ui":
                Ghost_1Image.SetActive(true);
                Ghost_1.SetActive(true);
                ReaperImage.SetActive(false);
                Reaper.SetActive(false);
                GhostImage.SetActive(false);
                Ghost.SetActive(false);
                GirlGhostImage.SetActive(false);
                GirlGhost.SetActive(false);
                SkeletonImage.SetActive(false);
                Skeleton.SetActive(false);
                break;

            case "GirlGhostUi":
                GirlGhostImage.SetActive(true);
                GirlGhost.SetActive(true);
                ReaperImage.SetActive(false);
                Reaper.SetActive(false);
                GhostImage.SetActive(false);
                Ghost.SetActive(false);
                Ghost_1Image.SetActive(false);
                Ghost_1.SetActive(false);
                SkeletonImage.SetActive(false);
                Skeleton.SetActive(false);
                break;

            case "SkeletonUi":
                SkeletonImage.SetActive(true);
                Skeleton.SetActive(true);
                ReaperImage.SetActive(false);
                Reaper.SetActive(false);
                GhostImage.SetActive(false);
                Ghost.SetActive(false);
                Ghost_1Image.SetActive(false);
                Ghost_1.SetActive(false);
                GirlGhostImage.SetActive(false);
                GirlGhost.SetActive(false);
                break;
        }

        Debug.Log($"{SelectName}");

        // characterObj 비활성
        Background.SetActive(false);
        BackButton.SetActive(false);
        ReaperUi.SetActive(false);
        GhostUi.SetActive(false);
        Ghost_1Ui.SetActive(false);
        GirlGhostUi.SetActive(false);
        SkeletonUi.SetActive(false);


        // StartObj 활성화
        Logo.SetActive(true);
        ExitButton.SetActive(true);
        CharacterButton.SetActive(true);
        ScoreCoin.SetActive(true);
        MoveNumber.SetActive(true);
        BestTxt.SetActive(true);
    }

    public void Restart()
    {
        // Restart 비활성화
        DBackground.SetActive(false);
        DGod.SetActive(false);
        DText.SetActive(false);
        RestartButton.SetActive(false);

        // StartObj 활성화
        Logo.SetActive(true);
        ExitButton.SetActive(true);
        CharacterButton.SetActive(true);
        ScoreCoin.SetActive(true);
        MoveNumber.SetActive(true);
        BestTxt.SetActive(true);

        // 처음 위치로 간다.(카메라, 캐릭터 위치)
        Player.transform.position = new Vector3(0f, 1f, 0f);
        Player.SetActive(true);
        Carmara.transform.position = new Vector3(0f, 0f, 0f);
        // 다가오는 카메라 멈추게 하기
        //Carmara.GetComponent<MainCameraAT>().isStopMove = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
    }
}

