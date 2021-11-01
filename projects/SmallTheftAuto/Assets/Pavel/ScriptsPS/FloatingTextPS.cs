using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTextPS : MonoBehaviour
{
    public GameObject textPrefab;
    private GameObject textInstance;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        textInstance = Instantiate(textPrefab);
    }

    // Update is called once per frame
    void OnDisable()
    {
        Destroy(textInstance);
    }
}
