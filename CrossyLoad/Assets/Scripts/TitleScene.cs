using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(NextScene());
        // Debug.Log($"다음 씬으로 넘어가나");
    }



    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene("MainScene");
    }


}
