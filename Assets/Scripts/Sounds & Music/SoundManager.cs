using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerPrefs.SetFloat("MusicVolume", 1);
        }
        volumeSlider.value = PlayerPrefs.GetFloat("MusicVolume");
    }

    public void ChangeVolume(){
        AudioListener.volume = volumeSlider.value;
        PlayerPrefs.SetFloat("MusicVolume", volumeSlider.value);
    }
}
