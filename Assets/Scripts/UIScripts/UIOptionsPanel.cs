using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class UIOptionsPanel : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetMusicVolume(float sliderValue)
    {
        mixer.SetFloat("Master", sliderValue > 0 ? Mathf.Log10(sliderValue) * 20 : -80);
    }


    public void Exit()
    {
        Application.Quit();
    }

    public void Retrun()
    {
        gameObject.SetActive(false);
    }

}
