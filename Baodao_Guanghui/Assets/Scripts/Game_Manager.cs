using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    //public GameObject Table1;//宣告一個物件(不想被刪除的場景)。
    //public GameObject Table2;
    //public GameObject Table3;
    //public GameObject Table4;

    //public GameObject Menu;
    public GameObject Shop;
    public GameObject Picture;
    public GameObject Left;
    public GameObject Right;

    AsyncOperation async;
    void Start()
    {
        //async = SceneManager.LoadSceneAsync(2);
        //async.allowSceneActivation = false;  //先禁止asyns執行動作，避免一執行專案就把場景換走
    }
    void Update()
    {
        //Debug.Log(async.progress);
    }
    public void Go_BuyMeat()
    {
        SceneManager.LoadScene(3);
    }

    public void Go_HotFried()
    {
        SceneManager.LoadScene(2);
        //DontDestroyOnLoad(Table1);//載入時不銷毀(不想被刪除的物件);
        //async.allowSceneActivation = true;
        //DontDestroyOnLoad(Table2);
        //DontDestroyOnLoad(Table3);
        //DontDestroyOnLoad(Table4);

    }

    public void Go_Tsai_Story()
    {
        SceneManager.LoadScene(6);
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

    public void Make_TsaiPuDan()
    {
        SceneManager.LoadScene(5);
        //SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }
}
