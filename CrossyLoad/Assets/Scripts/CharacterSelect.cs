using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{

    public GameObject popupWindow;

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

        popupWindow.GetComponent<PopupWindow>().SelectCharacter(gameObject.name);

    }


}
