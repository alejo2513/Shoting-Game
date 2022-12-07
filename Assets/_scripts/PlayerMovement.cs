 using System;
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Velocidad del movimeinto del persoanje en m/s")]
    [Range(0,10)]
    public float speed;
    
    [Tooltip("Velocidad de Rotación del personaje en grados/seg")]
    [Range(0,365)]
    public float rotationSpeed;

     void Start()
     {
         Cursor.visible = false;
         Cursor.lockState = CursorLockMode.Locked;
     }

    void Update()
    {
        float space = speed * Time.deltaTime;

        float horizontal = Input.GetAxis("Horizontal"); // -1 a 1
        float vertical = Input.GetAxis("Vertical"); //-1 a 1

        Vector3 dir = new Vector3(horizontal, 0, vertical);
        transform.Translate(dir.normalized*space);

        float angle = rotationSpeed * Time.deltaTime;
        float mouseX = Input.GetAxis("Mouse X"); //-1 a 1
        transform.Rotate(0,mouseX*angle,0);
    }
}
