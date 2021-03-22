using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanges : MonoBehaviour
{
    static SceneChanges instance;//核心
    public Add_Meat_Money script;

    private void Awake()
    {
        if (instance == null)//如果核心是空的
        {
            instance = this;//把唯一的Scenechanges丟到instance裡
            DontDestroyOnLoad(this);
            name = "最初遊戲開始的物件";
        }
        else if(this!=instance)//如果核心"不是"空的，代表SceneChanges是有多產生東西的
        {
            string sceneName = SceneManager.GetActiveScene().name;
            Debug.Log("刪除場景" + sceneName + "的" + name);//引入目前場景開啟名稱
            Destroy(gameObject);//把這個遊戲物件刪除
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
