using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Right : MonoBehaviour
{
    public GameObject cam;
    public Vector3 Vec;//設定的位置
    public Transform a;//攝影機
    public Transform b;//空物件位置
    public float speed;
    public GameObject back;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Cam_Right()
    {
        cam.transform.Translate(new Vector3(18f, 0, 0));
    }

    //private void OnMouseDown()
    //{
    //這邊是攝影機平移
    //cam.transform.Translate(new Vector3(10,0,0));
    //如果攝影機到空物件的位置，改攝影機位置
    //if(cam.transform.position == b.position)
    //{
    //cam.transform.position = Vec;//攝影機到設定位置
    //}
    //}
}

