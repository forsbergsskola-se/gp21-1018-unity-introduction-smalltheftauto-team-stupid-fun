using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneBoxQuestDB : PlayerMovement
{
    public GameObject Interaction;
    private void Start()
    {
        Interaction.SetActive(false);
        //anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void OpenInteractableIcon()
    {
        object interactIcon;
        interactIcon.SetActive(true);
    }

    public void CloseInteractableIcon();
}
