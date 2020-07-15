using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject virus;
    public float spawnTime;
    public float spawnDelay;
    
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        Instantiate(virus, transform.position, transform.rotation);
        
    }
}
