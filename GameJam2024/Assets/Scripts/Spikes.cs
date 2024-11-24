using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour
{
    public SpriteRenderer playerSkin;
    public Collider2D spikeCollider;
    public float timeSafe = 2f;
    public float timeHit;

    private void Start()
    {
        timeHit = Time.time;
    }

    private void Update()
    {
        if(Time.time < (timeHit + timeSafe))
        {
            playerSkin.color = new Color(1f, 1f, 1f, .7f);
        } else
        {
            playerSkin.color = Color.white;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Scene curScene = SceneManager.GetActiveScene();

        //Debug.LogError("Enter");
        if (other.tag == "Player" && Time.time > (timeHit + timeSafe))
        {
            GameDataManager.instance.lifeAmount--;
            timeHit = Time.time;

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
