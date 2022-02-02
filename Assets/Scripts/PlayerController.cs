using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //SayHelloMethod();
    }
    // Update is called once per frame
    void Update()
    {
        GurkBurk();
        CheckForInput();
    }

    private void CheckForInput()
    {
        
    }

    //void SayHelloMethod()
    //{
    //    print("Hello world");
    //}

    void GurkBurk()
    {
        if (true)
        {
            print("left or right");
        }
    }
}
