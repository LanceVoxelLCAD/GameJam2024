using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatsController : MonoBehaviour
{
    public TMP_Text monsterTxt;
    public float lifeAmount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        if (Input.GetKeyDown(KeyCode.H)) //DEBUG
        {
            lifeAmount++;
        } else if (Input.GetKeyDown(KeyCode.J)) //DEBUG
        {
            lifeAmount--;
        }

        monsterTxt.text = "x" + lifeAmount;
    }
}