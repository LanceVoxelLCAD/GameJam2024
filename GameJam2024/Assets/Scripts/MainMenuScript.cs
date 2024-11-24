using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{

    private string sceneName = "Level";
    public Button startGameButton;

    // Start is called before the first frame update
    void Start()
    {
        startGameButton.onClick.AddListener(OnButtonClicked);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnButtonClicked()
    {
        //Debug.Log("Button Clicked!");
        GameDataManager.instance.PauseGame(false);
        GameDataManager.instance.ShiftScene(sceneName);
    }
}
