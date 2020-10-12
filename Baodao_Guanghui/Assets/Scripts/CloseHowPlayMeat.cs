using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseHowPlayMeat : MonoBehaviour
{
    public GameObject HowToPlay;
    public GameObject Shop;
    public GameObject Picture;
    
    public GameObject Right1;
    private void OnMouseDown()
    {
        HowToPlay.SetActive(false);
        Shop.SetActive(true);
        Picture.SetActive(true);
        
        Right1.SetActive(true);

    }
}
