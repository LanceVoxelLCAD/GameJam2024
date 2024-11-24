using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLossScreens : MonoBehaviour
{
    public GameObject lossScreen;

    // Update is called once per frame
    void Update()
    {
        if (GameDataManager.instance.playerLost)
        {
            GameDataManager.instance.PauseGame(true);
            lossScreen.SetActive(true);
        }
    }
}
