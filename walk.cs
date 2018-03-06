using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class walk : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        print("hello world");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, -1.0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, 1.0f, 0f);
        }
    }
}