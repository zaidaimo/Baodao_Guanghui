using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointMeat : MonoBehaviour
{
    public Sprite[] MenuMeats;
       
    
    private void Start()
    {
        SpawnMeats();

    }

  
    void SpawnMeats()  //隨機位置 生成想要的物件
    {
        foreach (SpriteRenderer child in GetComponentsInChildren<SpriteRenderer>())
        {
            //child.sprite = MenuMeats[Random.Range(0,8)];

        }

    }

    
    
   




}
