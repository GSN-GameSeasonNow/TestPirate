using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Text processorName;
    public Text videoCardName;
    public Text memoryCount;

    void Start()
    {
        processorName.text = "Процессор:" + SystemInfo.processorType + "\n";
        videoCardName.text = "Видеокарта:" + SystemInfo.graphicsDeviceName;
        memoryCount.text = "Кол-во памяти: " + SystemInfo.systemMemorySize + "MB\n";
    }

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
