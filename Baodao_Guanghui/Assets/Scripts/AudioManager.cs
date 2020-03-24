using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer audioMixer;  //控制Mixer函數

    public void SetMasterVolume(float volume)  //控制主音量函數
    {
        audioMixer.SetFloat("MasterVolume", volume);
        //由MasterVolume為我們暴露出來的Master的參數
    }

    public void SetMusicVolume(float volume)  //控制背景音樂函數
    {
        audioMixer.SetFloat("MusicVolume", volume);
        //由MusicVolume為我們暴露出來的Music的參數
    }

    public void SetSoundEffectVolume(float volume)  //控制音效函數
    {
        audioMixer.SetFloat("SoundEffectVolume", volume);
        //由SoundEffectVolume為我們暴露出來的SoundEffect的參數
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
