using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Do_Hua_Quiz : MonoBehaviour
{
    public AudioClip Eat_Tsai_Pu_Dan;
    AudioSource audiosource;


    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        audiosource.PlayOneShot(Eat_Tsai_Pu_Dan);
    }
}
