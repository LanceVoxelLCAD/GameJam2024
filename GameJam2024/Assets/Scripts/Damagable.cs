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
    public GameObject cornerSpriteGood;
    public GameObject cornerSpriteHurt;

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
            Destroy(gameObject);

            if (gameObject.name == "BigBoss")
            {
                GameDataManager.instance.playerWon = true;
            }
        }
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Boss")
        {
            bossHealthBar.value = health;
        }
    }
}
