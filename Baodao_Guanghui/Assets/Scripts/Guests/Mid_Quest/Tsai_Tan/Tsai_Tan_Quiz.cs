using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tsai_Tan_Quiz : MonoBehaviour
{
    public AudioClip Eat_Tun_Tsu_Pai_Gu;
    AudioSource audiosource;


    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        audiosource.PlayOneShot(Eat_Tun_Tsu_Pai_Gu);
    }
}
