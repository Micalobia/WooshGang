using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Notes
//Always update the default input titles, Unity doesn't recognize the default names



public class CubeMovement : MonoBehaviour  
{
    public float cubemoveSpeed;

    void Start()
    {
        cubemoveSpeed = 10;
    }

    
    void Update()
    {
        transform.Translate(cubemoveSpeed*Input.GetAxis("CubeHorizontalMovement") * Time.deltaTime, 0f, cubemoveSpeed*Input.GetAxis("CubeVerticalMovement") * Time.deltaTime);
}
}
