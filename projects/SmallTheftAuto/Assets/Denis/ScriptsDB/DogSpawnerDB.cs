using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogSpawnerDB : MonoBehaviour
{
    public GameObject dogPrefab;
    private GameObject dogInstance;

// Start is called before the first frame update
    void OnEnable()
    {
        dogInstance = Instantiate(dogPrefab);
    }

// Update is called once per frame
    void Update()
    {
    
    }
    void OnDisable()
    {
        Destroy(dogInstance);
    }
}
