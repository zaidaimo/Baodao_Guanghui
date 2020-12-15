using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ro_Tan_Quiz : MonoBehaviour
{
    public AudioClip Eat_Kong_Bao_Gi_Ding;
    AudioSource audiosource;


    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        audiosource.PlayOneShot(Eat_Kong_Bao_Gi_Ding);
    }
}
