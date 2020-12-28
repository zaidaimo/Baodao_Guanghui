using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part_Time_Quiz : MonoBehaviour
{
    public AudioClip Eat_San_Bei_Gi;
    AudioSource audiosource;


    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        audiosource.PlayOneShot(Eat_San_Bei_Gi);
    }

}
