using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovementDB : MonoBehaviour
{
    public GameObject interactIcon;

// Start is called before the first frame update
    private void Start()
    {
        interactIcon.SetActive(false);
        //anime = GetComponent<Animator>();
    }

// Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 5f * Time.deltaTime * Input.GetAxis("Vertical"), 0f);
        transform.Rotate(0f,0f,-180 * Time.deltaTime * Input.GetAxis("Horizontal"));
    }

    public void OpenInteractableIcon()
    {
        interactIcon.SetActive(true);
    }

    public void CloseInteractableIcon()
    {
        interactIcon.SetActive(false);
    }

    public void CheckInteraction()
    {
        
    }
}
