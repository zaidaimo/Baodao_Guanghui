using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BuyMeat_Start : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(3);
    }

}
