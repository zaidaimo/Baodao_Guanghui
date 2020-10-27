using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quest_Base : MonoBehaviour
{
    
    private void OnMouseDown()
    {
        SceneManager.LoadScene(4);
    }
}
