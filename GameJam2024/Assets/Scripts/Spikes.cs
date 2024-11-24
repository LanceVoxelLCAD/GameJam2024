using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour
{
    public Collider2D spikeCollider;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Scene curScene = SceneManager.GetActiveScene();

        //Debug.LogError("Enter");
        if (other.tag == "Player")
        {
            GameDataManager.instance.lifeAmount--;

            if (GameDataManager.instance.lifeAmount <= 0)
            {
                GameDataManager.instance.lifeAmount = 0;
                GameDataManager.instance.playerLost = true;
            }

            if (curScene.name == "Level" & GameDataManager.instance.timerActive)
            {
                GameDataManager.instance.needToReturnPlayer = true;
            }

        }
    }
}
