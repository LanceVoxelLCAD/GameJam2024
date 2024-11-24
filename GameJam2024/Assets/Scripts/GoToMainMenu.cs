using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToMainMenu : MonoBehaviour
{
    private string sceneName = "MainMenu";
    public Button mainMenuButton;

    // Start is called before the first frame update
    void Start()
    {
        mainMenuButton.onClick.AddListener(OnButtonClicked);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnButtonClicked()
    {
        //Debug.Log("Button Clicked!");
        GameDataManager.instance.ShiftScene(sceneName);
        GameDataManager.instance.lifeAmount = 5;
        GameDataManager.instance.timerActive = false;
        GameDataManager.instance.needToReturnPlayer = false;
        GameDataManager.instance.playerLost = false;
        GameDataManager.instance.playerWon = false;
        GameDataManager.instance.PauseGame(false);
    }
}
