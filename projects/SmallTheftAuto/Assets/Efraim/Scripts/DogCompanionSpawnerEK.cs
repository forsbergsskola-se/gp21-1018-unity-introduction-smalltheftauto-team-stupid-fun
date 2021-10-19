using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCompanionSpawnerEK : MonoBehaviour {

    public GameObject DogPrefab;
    private GameObject dogInstance;

    void Start() {
        dogInstance = Instantiate(DogPrefab);
    }

    void Update() {
    }

    private void OnDestroy() {
        Destroy(dogInstance);
    }
}
