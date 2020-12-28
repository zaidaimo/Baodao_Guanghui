using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G_Pai_Quiz : MonoBehaviour
{
    public AudioClip Eat_Di_Gua_Yea;
    AudioSource audiosource;


    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        audiosource.PlayOneShot(Eat_Di_Gua_Yea);
    }
}
