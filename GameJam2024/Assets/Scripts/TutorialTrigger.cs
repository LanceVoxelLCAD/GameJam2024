using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTrigger : MonoBehaviour
{
    public GameObject tutorialPopUp;

    private void Start()
    {
        tutorialPopUp.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            tutorialPopUp.SetActive(true);
        } 

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            tutorialPopUp.SetActive(false);
        }
    }
}
