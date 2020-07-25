using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Ctrl : MonoBehaviour
{
    public Sprite[] Vegs;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(3);
        }
    }
    public void Random_Veg()
    {
        foreach (SpriteRenderer child in GetComponentsInChildren<SpriteRenderer>())
        {
            if(child.transform == transform)
            {
                continue; //跳過迴圈一次
            }
            child.sprite = Vegs[Random.Range(0, 15)];
        }
    }
}
