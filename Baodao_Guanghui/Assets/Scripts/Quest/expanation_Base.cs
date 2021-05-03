using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class expanation_Base : MonoBehaviour
{
    //public GameObject simp_guest_sp;
    //public GameObject simp_Guest;
    //public GameObject mid_guest_sp;
    //public GameObject mid_Guest;

    //public GameObject Left;

    //public Add_Meat_Money Script;

    public GameObject simp_refri;  //普通冰箱
    
    public GameObject adv_refri;  //進階冰箱
    public GameObject highlevel_refri;  //高階冰箱
    public void OnMouseDown()
    {
        SceneManager.LoadScene(4);
        Destroy(gameObject);

        //simp_guest_sp.SetActive(false);
        //simp_Guest.SetActive(false);
        //mid_guest_sp.SetActive(true);
        //mid_Guest.SetActive(true);

        //Left.SetActive(true);

        if (simp_refri.activeSelf)
        {
            DontDestroyOnLoad(simp_refri);
        }
    }

    
}
