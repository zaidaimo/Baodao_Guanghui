using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading_HotFried : MonoBehaviour
{
    AsyncOperation async;

    void Start()
    {
        async = SceneManager.LoadSceneAsync(2);

        async.allowSceneActivation = false;  //先禁止asyns執行動作，避免一執行專案就把場景換走
    }

    void Update()
    {
        Debug.Log(async.progress);

    }

    public void PressBack()
    {
        //async = SceneManager.LoadSceneAsync(2);
        async.allowSceneActivation = true;
    }



}

