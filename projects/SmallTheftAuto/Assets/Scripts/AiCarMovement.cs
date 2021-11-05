using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiCarMovement : MonoBehaviour
{
    public float x;
    public float y;
    void Update()
    {
        transform.Translate(x* Time.deltaTime,  0 , 0f);
        // transform.Rotate(0f,0f,-400 * Time.deltaTime);
    }
}
