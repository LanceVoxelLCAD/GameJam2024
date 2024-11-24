using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BossHud : MonoBehaviour
{
    public GameObject bossHud;
    //public Slider bossHealthBar;

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Boss")
        {
            bossHud.SetActive(true);
        }
        else
        {
            bossHud.SetActive(false);
        }

        //bossHealthBar.value 
    }
}
