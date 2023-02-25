using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartButton : MonoBehaviour, IPointerDownHandler
{
    public bool isStopMove = default; // 터치 전 동작 멈춤

    public GameObject Logo;
    public GameObject ExitButton;
    public GameObject CharacterButton;

    public void OnPointerDown(PointerEventData eventData)
    {
        isStopMove = true;

        Logo.SetActive(false);
        ExitButton.SetActive(false);
        CharacterButton.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
