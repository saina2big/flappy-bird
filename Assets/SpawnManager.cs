using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPipes()
    {
        Instantiate(pipePrefab, new Vector3(2,Random.Range(-3, 0.85f), 0), Quaternion.identity);
    }
}
