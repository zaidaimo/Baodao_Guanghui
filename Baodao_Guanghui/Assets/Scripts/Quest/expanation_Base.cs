using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class expanation_Base : MonoBehaviour
{
    public GameObject simp_guest_sp;
    public GameObject simp_Guest;
    public GameObject mid_guest_sp;
    public GameObject mid_Guest;

    //public GameObject Left;
    public void OnMouseDown()
    {
        SceneManager.LoadScene(4);
        Destroy(gameObject);

        simp_guest_sp.SetActive(false);
        //simp_Guest.SetActive(false);
        mid_guest_sp.SetActive(true);
        //mid_Guest.SetActive(true);

        //Left.SetActive(true);
    }
}
