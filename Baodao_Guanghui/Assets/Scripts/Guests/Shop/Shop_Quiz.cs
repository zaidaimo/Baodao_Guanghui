using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Quiz : MonoBehaviour
{
    public AudioClip Eat_Co_Gia_Xiao_Tsao;
    AudioSource audiosource;


    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        audiosource.PlayOneShot(Eat_Co_Gia_Xiao_Tsao);
    }
}
