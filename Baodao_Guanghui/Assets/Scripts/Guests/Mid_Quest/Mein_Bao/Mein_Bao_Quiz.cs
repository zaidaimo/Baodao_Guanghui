using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mein_Bao_Quiz : MonoBehaviour
{
    public AudioClip Eat_Kong_Sing_Tsai;
    AudioSource audiosource;


    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        audiosource.PlayOneShot(Eat_Kong_Sing_Tsai);
    }
}
