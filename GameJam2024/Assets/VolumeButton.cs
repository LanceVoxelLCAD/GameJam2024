using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
public class VolumeButton : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
    }
}