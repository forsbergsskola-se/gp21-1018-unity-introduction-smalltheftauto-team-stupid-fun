using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCompanionSpawnerNR : MonoBehaviour
{
    public GameObject dogPrefab;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(dogPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
