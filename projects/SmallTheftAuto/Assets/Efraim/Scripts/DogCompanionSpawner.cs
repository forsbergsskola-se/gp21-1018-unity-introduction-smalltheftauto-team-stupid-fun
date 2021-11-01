using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCompanionSpawner : MonoBehaviour {

    public GameObject dogPrefab;
    private GameObject dogInstance;

    void Start() {
        dogInstance = Instantiate(dogPrefab);
    }

    void Update() {
    }

    private void OnDestroy() {
        Destroy(dogInstance);
    }
}
