using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingTextNR : MonoBehaviour
{
    private TMPro.TextMeshProUGUI text;
    
    // Start is called before the first frame update
    void Start()
    {
        text = FindObjectOfType<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (text.color.a > 0)
        {
            this.transform.position += new Vector3(0, 2, 0) * Time.deltaTime;
            Color color = text.color;
            color.a -= 0.01f;
            text.color = color;
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
