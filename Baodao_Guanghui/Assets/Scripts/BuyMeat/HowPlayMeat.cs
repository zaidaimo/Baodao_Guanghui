using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowPlayMeat : MonoBehaviour
{
    public GameObject HowToPlay;
    public GameObject Shop;
    public GameObject Picture;
    
    public GameObject Right1;

    private void OnMouseDown()
    {
        HowToPlay.SetActive(true);
        Shop.SetActive(false);
        Picture.SetActive(false);
        
        Right1.SetActive(false);

    }
}
