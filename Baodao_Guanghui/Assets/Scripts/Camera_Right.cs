﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Right : MonoBehaviour
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

        public void Cam_Right()
        {
            cam.transform.Translate(new Vector3(25f, 0, 0));
        }
        //private void OnMouseDown()
        //{
        //cam.transform.Translate(new Vector3(-10, 0, 0));
        //if (cam.transform.position == b.position)
        //{
        //cam.transform.position = Vec;
        //}

        //}
   
}
