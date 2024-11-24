using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToBoss : MonoBehaviour
{
    private string sceneName = "Boss";
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Touched Level Transition Trigger");
            GameDataManager.instance.ShiftScene(sceneName);
        }
    }
}
