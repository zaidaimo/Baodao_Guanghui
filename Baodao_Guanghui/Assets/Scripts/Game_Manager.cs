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

    public void IsGame_False()
    {
        Spawn_Guest1.isGame = false;
        Spawn_Guest2.isGame = false;
        Spawn_Guest3.isGame = false;
        Spawn_Guest4.isGame = false;
    }

    public void IsGame_True()
    {
        Spawn_Guest1.isGame = true;
        Spawn_Guest2.isGame = true;
        Spawn_Guest3.isGame = true;
        Spawn_Guest4.isGame = true;
    }

    public void Go_Tsai_bo_nun()
    {
        SceneManager.LoadScene(5);
    }
}
