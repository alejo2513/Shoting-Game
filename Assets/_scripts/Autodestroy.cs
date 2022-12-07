using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autodestroy : MonoBehaviour
{
    
    [Tooltip("Tiempo en destruir el objeto")]
    public float destructionDelay;

    void OnEnable()
    {
        Invoke("HideObject", destructionDelay);
        
    }
    private void HideObject()
    {
        gameObject.SetActive(false);
    }
    // Start is called before the first frame update

}
