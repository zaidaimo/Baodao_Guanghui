using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teaching : MonoBehaviour
{
    //public GameObject Teach;
    public GameObject Teaching_Text;
    public float spawnTime;

    private void Start()
    {
        Invoke("ActiveShow", spawnTime);
        
    }

    public void ActiveShow()
    {
        Teaching_Text.SetActive(true);
    }

    public void Destroy_Teaching_Text()
    {
        Destroy(gameObject);
    }
}
