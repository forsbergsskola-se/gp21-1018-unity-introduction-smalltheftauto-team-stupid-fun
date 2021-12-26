using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Most simple traffic ai ever implemented :D
public class AiCarMovement : MonoBehaviour
{
    public float x;
    public float y;
    void Update()
    {
        transform.Translate(x* Time.deltaTime,  y * Time.deltaTime , 0f);
        // transform.Rotate(0f,0f,-400 * Time.deltaTime);
        
        Destroy(gameObject, 10f);
    }
}
