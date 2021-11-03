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
    
    
    // Start is called before the first frame update
    void Start()
    {
             
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TMP_Text text = GetComponentInChildren<TMP_Text>();
        if (text.color.a > 0)
        {
            transform.Translate(0f,.01f,0f);
            Color color = text.color;
            color.a -= 0.01f;
            text.color = color;
            new Vector3(0, 0, -1);
        }
        else 
        {
            Destroy(gameObject);
        }
        
        
    }
}
