using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    public Button quitButton;

    void Start()
    {
        quitButton.onClick.AddListener(OnButtonClicked);
    }

    public void OnButtonClicked()
    {
        //Debug.Log("You quit");
        Application.Quit();
    }


}
