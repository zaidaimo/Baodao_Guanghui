using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Left : MonoBehaviour
{
    public GameObject cam;
    public Vector3 Vec;
    public Transform a;
    public Transform b;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        cam.transform.Translate(new Vector3(-5, 0, 0));
        if (cam.transform.position == b.position)
        {
            cam.transform.position = Vec;
        }

    }
}
