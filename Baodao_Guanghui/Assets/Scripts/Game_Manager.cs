using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Shop;
    public GameObject Picture;
    public GameObject Left;
    public GameObject Right;
    public void Go_BuyMeat()
    {
        SceneManager.LoadScene(3);
    }

    public void Go_HotFried()
    {
        SceneManager.LoadScene(2);
    }

    
}
