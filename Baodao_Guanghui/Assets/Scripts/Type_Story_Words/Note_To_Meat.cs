using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note_To_Meat : MonoBehaviour
{

    public void Note_Meat()
    {
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
