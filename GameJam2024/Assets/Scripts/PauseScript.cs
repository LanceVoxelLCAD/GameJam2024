using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public Button pauseResumeButton;

    // Start is called before the first frame update
    void Start()
    {
        pauseResumeButton.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {

    }
}
