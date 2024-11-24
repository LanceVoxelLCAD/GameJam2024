using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterEnergyPickup : MonoBehaviour
{
    public SpriteRenderer monsterSingle;
    public Collider2D monsterCollider;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.LogError("Enter");
        if (other.tag == "Player")
        {
            monsterSingle.enabled = false;
            monsterCollider.enabled = false;
            GameDataManager.instance.lifeAmount++;
        }
    }
}
