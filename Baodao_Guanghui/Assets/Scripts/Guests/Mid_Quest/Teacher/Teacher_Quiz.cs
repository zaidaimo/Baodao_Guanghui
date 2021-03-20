using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teacher_Quiz : MonoBehaviour
{
    public AudioClip Eat_Ma_Po_Do_Fu;
    AudioSource audiosource;


    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    private void OnMouseDown()
    {
        audiosource.PlayOneShot(Eat_Ma_Po_Do_Fu);
    }
}
