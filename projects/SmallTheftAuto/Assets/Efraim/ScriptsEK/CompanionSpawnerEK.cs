using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionSpawnerEK : MonoBehaviour {
    public GameObject companionPrefab;
    private GameObject companionInstance;

    void Start() {
        companionInstance = Instantiate(companionPrefab);
    }

    private void OnDestroy() {
        Destroy(companionInstance);
    }
}
