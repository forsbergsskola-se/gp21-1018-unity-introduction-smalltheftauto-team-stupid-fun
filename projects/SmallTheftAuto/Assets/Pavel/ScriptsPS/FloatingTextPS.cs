using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class FloatingTextPS : MonoBehaviour
{

    public GameObject floatingTextPrefab;
    public GradientAlphaKey a;
    
    // Start is called before the first frame update
    void Start()
    {
             
        
    }

    // Update is called once per frame
    void Update()
    {
        if (floatingTextPrefab.activeSelf)
        {
            transform.Translate(0f,1f,0f);
            a.alpha -= 1;
        }
        else if (a.alpha == 0)
        {
            Destroy(gameObject);
        }
        
        
    }
}
