using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Damagable : MonoBehaviour
{
    public float health = 100f;
    public Slider bossHealthBar;

    public void Damage(float damageAmount)
    {
        health -= damageAmount;

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
