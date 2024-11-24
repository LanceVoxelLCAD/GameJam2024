using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDataManager : SceneSingleton<GameDataManager>
{
    public float lifeAmount = 5;
    public bool timerActive;
    public bool needToReturnPlayer;
    public bool playerLost;
    public bool playerWon;


    protected override void Awake()
    {
        base.Awake();
    }

    public void ShiftScene(string sceneName)
    {
        Debug.Log("LevelLoaded");
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void PauseGame(bool isPaused)
    {
        if (isPaused)
        {
            Time.timeScale = 0;
            isPaused = false;
        } else if (!isPaused)
        {
            Time.timeScale = 1;
            isPaused = true;
        }
       
    }

    //public void ExampleFunction()
    //{

    //}
}