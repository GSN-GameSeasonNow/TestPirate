using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public AudioMixer audioMixer;
    
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Mixer", Mathf.Log10(volume) * 20);
    }

    public void setQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    
    public void Sound()
    {
        AudioListener.pause = !AudioListener.pause;
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        //Application.OpenURL("https://www.youtube.com/watch?v=G1IbRujko-A&t=66s&ab_channel=10Hours");
    }


}
