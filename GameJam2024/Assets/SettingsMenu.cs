using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{

    public void GoToSettingScene()

    {
        SceneManager.LoadScene("Settings");
    }
}