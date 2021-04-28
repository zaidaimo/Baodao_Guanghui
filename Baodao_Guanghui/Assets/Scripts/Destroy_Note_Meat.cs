using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Note_Meat : MonoBehaviour
{
    void Update()
    {
        Destroy();
    }
    // Start is called before the first frame update
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
