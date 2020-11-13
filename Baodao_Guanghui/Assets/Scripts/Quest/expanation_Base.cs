using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class expanation_Base : MonoBehaviour
{
    
    public void OnMouseDown()
    {
        SceneManager.LoadScene(4);
        Destroy(gameObject);
    }
}
