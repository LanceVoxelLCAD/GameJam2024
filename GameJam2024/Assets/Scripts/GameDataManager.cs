using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDataManager : SceneSingleton<GameDataManager>
{

    protected override void Awake()
    {
        base.Awake();
    }

    public void ShiftScene(string sceneName)
    {
        //Debug.Log("LevelLoaded");
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    //public void ExampleFunction()
    //{

    //}
}