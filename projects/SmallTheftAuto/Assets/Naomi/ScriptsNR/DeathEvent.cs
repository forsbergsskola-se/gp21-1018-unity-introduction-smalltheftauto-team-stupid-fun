using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathEvent : MonoBehaviour
{
    [SerializeField] private Transform playerPosition;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private GameObject player;
    public TMPro.TextMeshProUGUI deathText;
    public GameObject defCanvas;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            PlayerDeathEvent();
        }
    }

    public void PlayerDeathEvent()
    {
        DeathText();
        Respawn();
    }

    public void Respawn()
    {
        playerPosition.transform.position = respawnPoint.transform.position;
        player.GetComponent<Currency>().LoseMoney();
        player.GetComponent<HealthSystem>().ResetHealth();
    }

    public void DeathText()
    {
        TMPro.TextMeshProUGUI wasted = Instantiate(deathText, transform.position, Quaternion.identity);
        wasted.transform.SetParent(defCanvas.transform, false);
        Destroy(wasted, 2);
    }


}
