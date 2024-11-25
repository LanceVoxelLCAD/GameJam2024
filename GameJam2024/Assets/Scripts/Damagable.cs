using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Damagable : MonoBehaviour
{
    public float health = 100f;
    private float maxBossHealth = 500f;
    public Slider bossHealthBar;
    public GameObject BigBoss;
    public GameObject cornerSpriteGood;
    public GameObject cornerSpriteHurt;
    public float waitForBossUI = 4f;
    public float timeBossKilled;
    public bool bossPhase2 = false;
    public GameObject bossUI;
    public GameObject smolBossAttacks;

    public void Damage(float damageAmount)
    {
        health -= damageAmount;

        if (health <= (.25 * maxBossHealth) && gameObject.name == "BigBoss")
        {
            cornerSpriteGood.SetActive(false);
            cornerSpriteHurt.SetActive(true);
        }
        else if (health > (.25 * maxBossHealth) && gameObject.name == "BigBoss")
        {
            cornerSpriteGood.SetActive(true);
            cornerSpriteHurt.SetActive(false);
        }

        if (health <= 0)
        {
            if (gameObject.name != "Bossnormalfinal")
            {
                Destroy(gameObject);
            }

            if (gameObject.name == "BigBoss")
            {
                GameDataManager.instance.playerWon = true;
            }

            if (gameObject.name == "Bossnormalfinal")
            {
                timeBossKilled = Time.time;
                bossPhase2 = true;
                smolBossAttacks.SetActive(false);
                bossUI.SetActive(true);
            }
        }
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Boss")
        {
            bossHealthBar.value = health;
        }

        if (bossPhase2 && Time.time > (waitForBossUI + timeBossKilled))
        {
            bossUI.SetActive(false);
            Destroy(gameObject);
            BigBoss.SetActive(true);
        }
    }
}
