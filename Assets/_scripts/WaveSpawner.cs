using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [Tooltip("Generador de enemigos")] 
    public GameObject prefab;

    [Tooltip("Tiempo en el que se inicia y finaliza una oleada")]
    public float startTime, endTime;

    [Tooltip("Tiempo entre enemigos")]
    public float spawnRate;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startTime, spawnRate);
        Invoke("CancelInvoke", endTime);
    }

    void SpawnEnemy()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }

}
