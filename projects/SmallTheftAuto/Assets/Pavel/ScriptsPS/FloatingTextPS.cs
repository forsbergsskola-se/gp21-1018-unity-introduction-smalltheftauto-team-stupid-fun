using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(TMP_Text))]
public class FloatingTextPS : MonoBehaviour
{

    public string displayText;
    
    // Start is called before the first frame update
    void Start()
    {
        

        if (GetComponent<CarMovementPS>() == enabled )
        {
            TMP_Text tmp_text = GetComponent<TMP_Text>();
            tmp_text.text = displayText;
            tmp_text.D
        }
    }

    // Update is called once per frame
    
}
